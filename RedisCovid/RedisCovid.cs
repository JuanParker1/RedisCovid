using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using System.Net;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

// Authors: Álvaro Otero Pizarro & Ángel Solís Trejo

namespace RedisCovid
{
    public partial class Form1 : Form
    {
        private static bool connectionStatus = false; 
        private static IDatabase? _redisDB;
        private const string NO_DATA_FOUND = "###NoDataFound###";
        public static string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        PropertyInfo? imageRectangleProperty = typeof(PictureBox).GetProperty("ImageRectangle", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);

        public Form1()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public bool IsConnected() { return connectionStatus; }
        public void SetConnectionStatus(bool status) { connectionStatus = status; }
        public bool ConnectionIsNotNull() {  return _redisDB != null; }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblConnectionStatus.Text = "Desconectado";
            lblConnectionStatus.ForeColor = Color.Red;
            _redisDB = Redis.Connection.GetDatabase();
      
            if(_redisDB != null)
            {
                lblConnectionStatus.Text = "Conectado!";
                lblConnectionStatus.ForeColor = Color.Green;
                SetConnectionStatus(true);
            }
            else
            {
                SetConnectionStatus(false);
            }
        }

        private void btnPutTaburete_Click(object sender, EventArgs e)
        {
            if(IsConnected())
            {
                if (PutString(textBox1.Text, textBox2.Text))
                {
                    lblResultMessage.Text = "Se han insertado los datos correctamente.";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la conexión.", "Error");
            }
        }

        public bool PutString(string key, string value)
        {
            if(_redisDB != null)
            {   
                return _redisDB.StringSet(key, value);
            }
            else
            {
                return false;
            }
        }

        public void PutHashEntries(string hashName, HashEntry[] hashFields)
        {
            if(_redisDB != null)
            {
                _redisDB.HashSet(hashName, hashFields);
            }
        }

        public async Task Parseo()
        {
            await Task.Run(() =>
            {
                DateTime date = new DateTime(2020, 01, 01);
                DateTime endDate = new DateTime(2022, 05, 22);
                int fileCounter = 0, filesParsed = 0;
                WebClient webClient = new WebClient();

                if (!Directory.Exists(PATH + @"\CovidJSONFiles"))
                {
                    Directory.CreateDirectory(PATH + @"\CovidJSONFiles");
                }


                while (date <= endDate)
                {    
                    if (!File.Exists(PATH + @"\CovidJSONFiles\" + date.ToString("yyyy-MM-dd") + ".json"))
                    {

                        try
                        {
                            webClient.DownloadFile("https://api.covid19tracking.narrativa.com/api/" + date.ToString("yyyy-MM-dd") + "/country/spain", PATH + @"\Extremadura\" + date.ToString("yyyy-MM-dd") + ".json");
                            fileCounter++;
                           

                            //Console.WriteLine("File: " + date.ToString("yyyy-MM-dd") + ".json downloaded");
                        }
                        catch { }
                    }
                    else
                    {

                        //Console.WriteLine("File: " + date.ToString("yyyy-MM-dd") + ".json  already downloaded");
                    }
                    date = date.AddDays(1);
                }

                //Console.WriteLine(fileCounter + " files downloaded!");

                Root? root;

                foreach (var file in Directory.GetFiles(PATH + @"\CovidJSONFiles"))
                {
                    if (new System.IO.FileInfo(file).Length > 0)
                    {    
                        string json = File.ReadAllText(file);
                        CorrectCovidJson(GetDateFromJsonCovid(json), ref json);
                        try
                        {
                            root = JsonConvert.DeserializeObject<Root>(json);

                            if(root != null)
                            {
                                foreach (var r in root.Dates.TheCovid19.Countries.Spain.Regions)
                                {

                                }
                                filesParsed++;
                                //Console.WriteLine(file + " parsed!");
                            }
                        }
                        catch { /*Console.WriteLine(file + " could not be parsed");*/ }
                    }
                }
                Invoke(new MethodInvoker(() =>
                {
                    lblConnectionStatus.Text = filesParsed.ToString();
                }));
                //Console.WriteLine(filesParsed + " files parsed!");
            });
        }

        public static string GetDateFromJsonCovid(string json)
        {
            return json.Substring(11, 10);
        }

        public static void CorrectCovidJson(string date, ref string json)
        {
            json = json.Remove(11, 10).Insert(11, "TheCovid19");
        }

        public HashEntry[]? GetHashEntries(string hashName)
        {
            if(_redisDB != null)
            {
                return _redisDB.HashGetAll(hashName);
            }
            else { return null; }
        }

        public RedisValue? GetHashEntry(string hashName, string fieldName)
        {
            if(_redisDB != null)
            {
                return _redisDB.HashGet(hashName, fieldName);
            }
            else { return null; }
        }

        public void PutHashEntry(string hashName, HashEntry hashField)
        {
            if (_redisDB != null)
            {
                _redisDB.HashSet(hashName, hashField.Name, hashField.Value);
            }
        }

        public IDatabase? Get_redisDB()
        {
            return _redisDB;
        }



        /// <summary>Busca si ya existe o no el campo de un hash dado.</summary>
        /// <param name="hashName">Nombre del hash.</param>
        /// <param name="hashField">Nombre del campo del hash.</param>
        /// <returns>True en caso de que ya exista el field, false en caso contrario.</returns>
        public bool ExistsHashField(string hashName, HashEntry hashField)
        {
            if(_redisDB != null)
            {
                return _redisDB.HashExists(hashName, hashField.Name);
            }
            //else
            {
                return false;
            }
        }


        public RedisValue GetString(string key)
        {
            if (_redisDB != null)
            {
                return _redisDB.StringGet(key);
            }
            else
            {
                return NO_DATA_FOUND;
            }
        }

        private void btnObtenerTaburete_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                var valor = GetString(textBox1.Text);

                labelResult.Text = RedisValue.Unbox(valor).ToString();
                    
            }
            else
            {
                MessageBox.Show("No se pudo realizar la conexión.", "Error");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Parseo();
        }

        private void Extremadura_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pixelColour = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);
                if(pixelColour.A == 0)
                {
                    lblConnectionStatus.Text = pictureBox1.Name;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;

                Bitmap original = (Bitmap)pictureBox1.Image;

                Color? color = null;
                switch (pictureBox1.SizeMode)
                {
                    case PictureBoxSizeMode.Normal:
                    case PictureBoxSizeMode.AutoSize:
                        {
                            color = original.GetPixel(me.X, me.Y);
                            break;
                        }
                    case PictureBoxSizeMode.CenterImage:
                    case PictureBoxSizeMode.StretchImage:
                    case PictureBoxSizeMode.Zoom:
                        {
                            Rectangle rectangle;    
                            object? ob = imageRectangleProperty?.GetValue(pictureBox1, null);

                            if(ob != null)
                            {
                                rectangle = (Rectangle)ob;
                                if (rectangle.Contains(me.Location))
                                {
                                    using (Bitmap copy = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height))
                                    {
                                        using (Graphics g = Graphics.FromImage(copy))
                                        {
                                            g.DrawImage(pictureBox1.Image, rectangle);

                                            color = copy.GetPixel(me.X, me.Y);
                                        }
                                    }
                                }
                            }                           
                        }                           
                        break;
                }

                if (!color.HasValue)
                {
                    //User clicked somewhere there is no image
                }
                else
                {
                    string colorRGB = "R: " + color.Value.R.ToString() + ", G: " + color.Value.G.ToString() + ", B: " + color.Value.B.ToString();
                    string comunidad;
                    switch(colorRGB)
                    {
                        case "R: 212, G: 60, B: 192": { comunidad = "Galicia";} break;
                        case "R: 0, G: 181, B: 205": { comunidad = "Asturias"; } break;
                        case "R: 222, G: 61, B: 87": { comunidad = "Cantabria"; } break;
                        case "R: 131, G: 1, B: 225": { comunidad = "País Vasco"; } break;
                        case "R: 111, G: 177, B: 121": { comunidad = "Navarra"; } break;
                        case "R: 0, G: 24, B: 255": { comunidad = "La Rioja"; } break;
                        case "R: 255, G: 0, B: 0": { comunidad = "Aragón"; } break;
                        case "R: 0, G: 255, B: 0": { comunidad = "Cataluña"; } break;
                        case "R: 251, G: 255, B: 0": { comunidad = "Comunidad Valenciana"; } break;
                        case "R: 0, G: 44, B: 4": { comunidad = "Murcia"; } break;
                        case "R: 116, G: 81, B: 4": { comunidad = "Andalucía"; } break;
                        case "R: 81, G: 208, B: 180": { comunidad = "Extremadura"; } break;
                        case "R: 255, G: 163, B: 0": { comunidad = "Castilla y León"; } break;
                        case "R: 191, G: 130, B: 203": { comunidad = "Castilla-La Mancha"; } break;
                        case "R: 52, G: 6, B: 0": { comunidad = "Madrid"; } break;
                        case "R: 255, G: 141, B: 225": { comunidad = "Islas Baleares"; } break;
                        case "R: 0, G: 222, B: 0": { comunidad = "Islas Canarias"; } break;
                        case "R: 164, G: 55, B: 55": { comunidad = "Ceuta"; } break;
                        case "R: 17, G: 132, B: 3": { comunidad = "Melilla"; } break;
                        default: { comunidad = "???"; } break;
                    }
                    if(comunidad != "???")
                    {
                        lblConnectionStatus.Text = comunidad.ToString();
                    }
                }
            }
        }
    }

    public class Redis
    {
        // Se usa Lazy cuando la creación de un objeto es tediosa...
        private static Lazy<ConnectionMultiplexer> _connection;

        public static ConnectionMultiplexer Connection
        {
            get { return _connection.Value; }            
        }

        static Redis()
        {
            _connection = new Lazy<ConnectionMultiplexer>(()=> ConnectionMultiplexer.Connect("localhost"));
        }
    }
}
