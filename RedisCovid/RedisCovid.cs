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
using System.Threading;

// Authors: Álvaro Otero Pizarro & Ángel Solís Trejo

namespace RedisCovid
{
    public partial class Form1 : Form
    {
        private static bool connectionStatus = false; 
        private static IDatabase? _redisDB;
        private const string NO_DATA_FOUND = "###NoDataFound###";
        public static string PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string currentCommunity = "???";
        public const string FORBIDDEN_DATE_1 = "2021-01-27", FORBIDDEN_DATE_2 = "2022-01-09";
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public async Task ChangeCommunityAsync(string name)
        {
            await Task.Run(() =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    currentCommunity = name;
                    lblSelectedCommunity.Text = name;
                }));
            });
        }
        #endregion

        public bool IsConnected() { return connectionStatus; }
        public void SetConnectionStatus(bool status) { connectionStatus = status; }
        public bool ConnectionIsNotNull() {  return _redisDB != null; }
        private void Form1_Load(object sender, EventArgs e)
        {
            dTimeStart.MaxDate = DateTime.Today;
            dTimeFin.MaxDate = DateTime.Today;
            dTimeFin.Visible = false;
            lblFinDateTimePicker.Visible = false;
            lblTotalDays.Visible = false;
            lblConnectionStatus.Text = "Desconectado de Redis";
            lblConnectionStatus.ForeColor = Color.Red;
            _redisDB = Redis.Connection.GetDatabase();
      
            if(_redisDB != null)
            {
                lblConnectionStatus.Text = "Conexión a Redis: OK";
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
                if(connectionStatus)
                {
                    DateTime today = DateTime.Today;
                    DateTime date = new DateTime(2020, 01, 01);
                    DateTime endDate = new DateTime(today.Year, today.Month, today.Day);
                    int totalDays = (int)(endDate - date).TotalDays;
                    int fileCounter = 0, filesParsed = 0;
                    WebClient webClient = new WebClient();

                    if (!Directory.Exists(PATH + @"\CovidJSONFiles"))
                    {
                        Directory.CreateDirectory(PATH + @"\CovidJSONFiles");
                    }

                    Invoke(new MethodInvoker(() =>
                    {
                        prBarParse.Value = 0;
                        prBarParse.Visible = true;
                        prBarParse.Maximum = totalDays + 1;
                        lblProgessBar.Visible = true;
                        lblTotalParsedFiles.Visible = false;
                        btnParse.Text = "DESCARGANDO...";
                    }));

                    while (date <= endDate)
                    {
                        if (!File.Exists(PATH + @"\CovidJSONFiles\" + date.ToString("yyyy-MM-dd") + ".json"))
                        {
                            try
                            {                 
                                webClient.DownloadFile("https://api.covid19tracking.narrativa.com/api/" + date.ToString("yyyy-MM-dd") + "/country/spain", PATH + @"\CovidJSONFiles\" + date.ToString("yyyy-MM-dd") + ".json");
                            }
                            catch {}
                        }
                        date = date.AddDays(1);
                        fileCounter++;

                        Invoke(new MethodInvoker(() =>
                        {
                            lblProgessBar.Text = ((fileCounter * 100) / totalDays).ToString() + "%";
                            prBarParse.Value += 1;
                        }));
                    }

                    Root? root;
                    Hash hash = null!;
                    string currentDate;
                    string[] files = Directory.GetFiles(PATH + @"\CovidJSONFiles");
                    int totalFiles = files.Length;

                    
                    Invoke(new MethodInvoker(() =>
                    {
                        btnParse.Text = "PARSEANDO...";
                        prBarParse.Maximum = totalFiles;
                        prBarParse.Value = 0;
                    }));
                    foreach (var file in files)
                    {
                        hash = new Hash();
                        if (new System.IO.FileInfo(file).Length > 0)
                        {
                            string json = File.ReadAllText(file);
                            currentDate = GetDateFromJsonCovid(json);
                            CorrectCovidJson(currentDate, ref json);
                            try
                            {
                                root = JsonConvert.DeserializeObject<Root>(json);
                                hash.SetHashName(currentDate);
                                if (root != null)
                                {
                                    foreach (var r in root.Dates.TheCovid19.Countries.Spain.Regions)
                                    {
                                        hash.AddEntry(r.Name, JsonConvert.SerializeObject(r));

                                    }
                                    hash.AddEntry("Total", JsonConvert.SerializeObject(root.Total));
                                    filesParsed++;
                                }
                            }
                            catch { /*Console.WriteLine(file + " could not be parsed");*/ }
                        }
                        else
                        {
                            totalFiles--;
                        }
                        PutHashEntries(hash.GetHashName(), hash.GetFields().ToArray());
                        Invoke(new MethodInvoker(() =>
                        {
                            prBarParse.Value += 1;
                            lblProgessBar.Text = ((filesParsed * 100) / totalFiles) + "%";
                        }));
                    }

                    Invoke(new MethodInvoker(() =>
                    {
                        lblTotalParsedFiles.Text = filesParsed.ToString() + " ARCHIVOS IMPORTADOS";
                        prBarParse.Visible = false;
                        lblProgessBar.Text = "0%";
                        lblProgessBar.Visible = false;
                        lblTotalParsedFiles.Visible = true;
                        btnParse.Text = "IMPORTAR DATOS";
                    }));
                }
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
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Borra un campo de un hash a partir del nombre del campo que se desea borrar.
        /// </summary>
        /// <param name="hashName">Nombre del hash.</param>
        /// <param name="fieldName">Nombre del campo a borrar.</param>
        /// <returns>True si lo ha borrado, false en caso contrario.</returns>
        public bool DeleteHashField(string hashName, string fieldName)
        {
            if(_redisDB != null)
            {
                return _redisDB.HashDelete(hashName, fieldName);
            }
            else
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
           /* if (IsConnected() && textBox1.Text != "")
            {
                lblPositivos.Text = GetHashEntry(textBox1.Text, "Total").ToString();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la conexión.", "Error");
            }*/
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
        private async void pictureBox1_Click_1(object sender, EventArgs e)
        {
            await SeleccionarComunidad(e);
        }
        public async Task SeleccionarComunidad(EventArgs e)
        {
            await Task.Run(() =>
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

                            if (ob != null)
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
                        switch (colorRGB)
                        {
                            case "R: 245, G: 57, B: 197": { comunidad = "Galicia"; } break;
                            case "R: 0, G: 182, B: 207": { comunidad = "Asturias"; } break;
                            case "R: 255, G: 59, B: 87": { comunidad = "Cantabria"; } break;
                            case "R: 154, G: 0, B: 230": { comunidad = "País Vasco"; } break;
                            case "R: 61, G: 179, B: 119": { comunidad = "Navarra"; } break;
                            case "R: 0, G: 17, B: 255": { comunidad = "La Rioja"; } break;
                            case "R: 255, G: 0, B: 0": { comunidad = "Aragón"; } break;
                            case "R: 0, G: 255, B: 0": { comunidad = "Cataluña"; } break;
                            case "R: 250, G: 255, B: 0": { comunidad = "C. Valenciana"; } break;
                            case "R: 101, G: 101, B: 85": { comunidad = "Murcia"; } break;
                            case "R: 128, G: 80, B: 0": { comunidad = "Andalucía"; } break;
                            case "R: 0, G: 209, B: 180": { comunidad = "Extremadura"; } break;
                            case "R: 255, G: 127, B: 39": { comunidad = "Castilla y León"; } break;
                            case "R: 211, G: 131, B: 207": { comunidad = "Castilla-La Mancha"; } break;
                            case "R: 4, G: 4, B: 4": { comunidad = "Madrid"; } break;
                            case "R: 255, G: 142, B: 229": { comunidad = "Baleares"; } break;
                            case "R: 0, G: 223, B: 0": { comunidad = "Canarias"; } break;
                            case "R: 190, G: 52, B: 52": { comunidad = "Ceuta"; } break;
                            case "R: 0, G: 133, B: 0": { comunidad = "Melilla"; } break;
                            case "R: 255, G: 92, B: 123": { comunidad = "Total"; } break;
                            default: { comunidad = "???"; } break;
                        }

                        currentCommunity = comunidad;

                        ShowResults();
                    }
                }
            });
        }
        public List<SubRegion> GetSubregions(Region region)
        {
            List<SubRegion> subRegions = new List<SubRegion>();

            foreach(var s in region.Sub_Regions)
            {
                subRegions.Add(s);
            }
            return subRegions;
        }
        public async Task ShowResultsAsync()
        {
            await Task.Run(() =>
            {
                if (currentCommunity != "???")
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        lblSelectedCommunity.Text = currentCommunity.ToUpper();
                    }));

                    if (chBoxRango.Checked)
                    {// Inicio y fin
                        DateTime startDay = new DateTime(dTimeStart.Value.Year, dTimeStart.Value.Month, dTimeStart.Value.Day);
                        DateTime endDay = new DateTime(dTimeFin.Value.Year, dTimeFin.Value.Month, dTimeFin.Value.Day);
                        Region? regionSum = new Region();
                        Region? region = null!;
                        Subregion s = null!;
                        List<SubRegion> subRegions = null!;
                        string? json = null!;
                        int totalDays = 0;

                        Invoke(new MethodInvoker(() =>
                        {
                            panelSubRegions.Controls.Clear();
                            panelSubRegions.VerticalScroll.Enabled = false;
                            panelSubRegions.HorizontalScroll.Enabled = true;
                        }));

                        while (startDay <= endDay)
                        {
                            region = new Region();

                            if (startDay.ToString("yyyy-MM-dd") == FORBIDDEN_DATE_1 || startDay.ToString("yyyy-MM-dd") == FORBIDDEN_DATE_2)
                            {
                                totalDays--;
                            }
                            else
                            {
                                json = GetHashEntry(startDay.ToString("yyyy-MM-dd"), currentCommunity);
                                if (json != null)
                                {
                                    region = JsonConvert.DeserializeObject<Region>(json);
                                    
                                    if (region != null)
                                    {
                                        if (subRegions == null)
                                        {// Esto sólo se ejecutará una vez...
                                            subRegions = GetSubregions(region);
                                            foreach(var sub in subRegions)
                                            {
                                                sub.Today_New_Recovered = 0;
                                                sub.Today_New_Deaths = 0;
                                                sub.Today_New_Confirmed = 0;
                                            }
                                        }

                                        foreach (var sub in region.Sub_Regions)
                                        {
                                            foreach(var subR in subRegions)
                                            {
                                                if(subR.Name == sub.Name)
                                                {
                                                    subR.Today_New_Recovered += sub.Today_New_Recovered;
                                                    subR.Today_New_Deaths += sub.Today_New_Deaths;
                                                    subR.Today_New_Confirmed += sub.Today_New_Confirmed;
                                                    break;
                                                }
                                            }
                                        }

                                        regionSum.Today_New_Confirmed += region.Today_New_Confirmed;
                                        regionSum.Today_New_Deaths += region.Today_New_Deaths;
                                        regionSum.Today_New_Total_Hospitalised_Patients += region.Today_New_Total_Hospitalised_Patients;
                                        regionSum.Today_New_Intensive_Care += region.Today_New_Intensive_Care;
                                        totalDays++; 
                                    }
                                }
                            }
                            startDay = startDay.AddDays(1);
                        }
                                               

                        Invoke(new MethodInvoker(() =>
                        {
                            lblPositivos.Text = regionSum.Today_New_Confirmed.ToString();
                            lblTotalPositivos.Text = "---";
                            lblMuertes.Text = regionSum.Today_New_Deaths.ToString();
                            lblTotalMuertes.Text = "---";
                            lblIngresados.Text = regionSum.Today_New_Total_Hospitalised_Patients.ToString();
                            lblTotalIngresados.Text = "---";
                            lblUci.Text = regionSum.Today_New_Intensive_Care.ToString();
                            lblTotalUci.Text = "---";

                            foreach(var subR in subRegions)
                            {
                                s = new Subregion();
                                s.ChangeName(subR.Name);
                                s.SetPositivos(subR.Today_New_Confirmed.ToString());
                                s.SetMuertes(subR.Today_New_Deaths.ToString());
                                s.SetCurados(subR.Today_New_Recovered.ToString());

                                panelSubRegions.Controls.Add(s);
                            }
                        }));
                    }
                    else
                    {// Inicio
                        string date = dTimeStart.Value.ToString("yyyy-MM-dd");
                        if (date != FORBIDDEN_DATE_1 && date != FORBIDDEN_DATE_2)
                        {
                            string? json = GetHashEntry(dTimeStart.Value.ToString("yyyy-MM-dd"), currentCommunity);

                            if (json != null)
                            {
                                Region? region = new Region();
                                region = JsonConvert.DeserializeObject<Region>(json);

                                if (region != null)
                                {
                                    Invoke(new MethodInvoker(() =>
                                    {
                                        lblPositivos.Text = region.Today_New_Confirmed.ToString();
                                        lblTotalPositivos.Text = region.Today_Confirmed.ToString();
                                        lblMuertes.Text = region.Today_New_Deaths.ToString();
                                        lblTotalMuertes.Text = region.Today_Deaths.ToString();
                                        lblIngresados.Text = region.Today_New_Total_Hospitalised_Patients.ToString();
                                        lblTotalIngresados.Text = region.Today_Total_Hospitalised_Patients.ToString();
                                        lblUci.Text = region.Today_New_Intensive_Care.ToString();
                                        lblTotalUci.Text = region.Today_Intensive_Care.ToString();
                                    }));
                                }

                                Invoke(new MethodInvoker(() =>
                                {
                                    panelSubRegions.Controls.Clear();
                                    panelSubRegions.VerticalScroll.Enabled = false;
                                    panelSubRegions.HorizontalScroll.Enabled = true;

                                    Subregion s = null!;

                                    if (region != null)
                                    {
                                        List<SubRegion> subRegions = GetSubregions(region);

                                        foreach (var sub in subRegions)
                                        {
                                            s = new Subregion();
                                            s.ChangeName(sub.Name);
                                            s.SetMuertes(sub.Today_New_Deaths.ToString());
                                            s.SetMuertosTotal(sub.Today_Deaths.ToString());
                                            s.SetPositivosTotal(sub.Today_Confirmed.ToString());
                                            s.SetPositivos(sub.Today_New_Confirmed.ToString());
                                            s.SetCurados(sub.Today_New_Recovered.ToString());
                                            s.SetCuradosTotal(sub.Today_Recovered.ToString());
                                            panelSubRegions.Controls.Add(s);
                                        }
                                    }                                    
                                }));
                            }
                        }
                    }
                }
            });
        }
        public void ShowResults()
        {
            if (currentCommunity != "???")
            {
                Invoke(new MethodInvoker(() =>
                {
                    lblSelectedCommunity.Text = currentCommunity.ToUpper();
                }));

                if (chBoxRango.Checked)
                {// Inicio y fin
                    DateTime startDay = new DateTime(dTimeStart.Value.Year, dTimeStart.Value.Month, dTimeStart.Value.Day);
                    DateTime endDay = new DateTime(dTimeFin.Value.Year, dTimeFin.Value.Month, dTimeFin.Value.Day);
                    Region? regionSum = new Region();
                    Region? region = null!;
                    Subregion s = null!;
                    List<SubRegion> subRegions = null!;
                    string? json = null!;
                    int totalDays = 0;

                    Invoke(new MethodInvoker(() =>
                    {
                        panelSubRegions.Controls.Clear();
                        panelSubRegions.VerticalScroll.Enabled = false;
                        panelSubRegions.HorizontalScroll.Enabled = true;
                    }));

                    while (startDay <= endDay)
                    {
                        region = new Region();

                        if (startDay.ToString("yyyy-MM-dd") == FORBIDDEN_DATE_1 || startDay.ToString("yyyy-MM-dd") == FORBIDDEN_DATE_2)
                        {
                            totalDays--;
                        }
                        else
                        {
                            json = GetHashEntry(startDay.ToString("yyyy-MM-dd"), currentCommunity);
                            if (json != null)
                            {
                                region = JsonConvert.DeserializeObject<Region>(json);

                                if (region != null)
                                {
                                    if (subRegions == null)
                                    {// Esto sólo se ejecutará una vez...
                                        subRegions = GetSubregions(region);
                                        foreach (var sub in subRegions)
                                        {
                                            sub.Today_New_Recovered = 0;
                                            sub.Today_New_Deaths = 0;
                                            sub.Today_New_Confirmed = 0;
                                        }
                                    }

                                    foreach (var sub in region.Sub_Regions)
                                    {
                                        foreach (var subR in subRegions)
                                        {
                                            if (subR.Name == sub.Name)
                                            {
                                                subR.Today_New_Recovered += sub.Today_New_Recovered;
                                                subR.Today_New_Deaths += sub.Today_New_Deaths;
                                                subR.Today_New_Confirmed += sub.Today_New_Confirmed;
                                                break;
                                            }
                                        }
                                    }

                                    regionSum.Today_New_Confirmed += region.Today_New_Confirmed;
                                    regionSum.Today_New_Deaths += region.Today_New_Deaths;
                                    regionSum.Today_New_Total_Hospitalised_Patients += region.Today_New_Total_Hospitalised_Patients;
                                    regionSum.Today_New_Intensive_Care += region.Today_New_Intensive_Care;
                                    totalDays++;
                                }
                            }
                        }
                        startDay = startDay.AddDays(1);
                    }


                    Invoke(new MethodInvoker(() =>
                    {
                        lblPositivos.Text = regionSum.Today_New_Confirmed.ToString();
                        lblTotalPositivos.Text = "---";
                        lblMuertes.Text = regionSum.Today_New_Deaths.ToString();
                        lblTotalMuertes.Text = "---";
                        lblIngresados.Text = regionSum.Today_New_Total_Hospitalised_Patients.ToString();
                        lblTotalIngresados.Text = "---";
                        lblUci.Text = regionSum.Today_New_Intensive_Care.ToString();
                        lblTotalUci.Text = "---";

                        foreach (var subR in subRegions)
                        {
                            s = new Subregion();
                            s.ChangeName(subR.Name);
                            s.SetPositivos(subR.Today_New_Confirmed.ToString());
                            s.SetMuertes(subR.Today_New_Deaths.ToString());
                            s.SetCurados(subR.Today_New_Recovered.ToString());

                            panelSubRegions.Controls.Add(s);
                        }
                    }));
                }
                else
                {// Inicio
                    string date = dTimeStart.Value.ToString("yyyy-MM-dd");
                    if (date != FORBIDDEN_DATE_1 && date != FORBIDDEN_DATE_2)
                    {
                        string? json = GetHashEntry(dTimeStart.Value.ToString("yyyy-MM-dd"), currentCommunity);

                        if (json != null)
                        {
                            Region? region = new Region();
                            region = JsonConvert.DeserializeObject<Region>(json);

                            if (region != null)
                            {
                                Invoke(new MethodInvoker(() =>
                                {
                                    lblPositivos.Text = region.Today_New_Confirmed.ToString();
                                    lblTotalPositivos.Text = region.Today_Confirmed.ToString();
                                    lblMuertes.Text = region.Today_New_Deaths.ToString();
                                    lblTotalMuertes.Text = region.Today_Deaths.ToString();
                                    lblIngresados.Text = region.Today_New_Total_Hospitalised_Patients.ToString();
                                    lblTotalIngresados.Text = region.Today_Total_Hospitalised_Patients.ToString();
                                    lblUci.Text = region.Today_New_Intensive_Care.ToString();
                                    lblTotalUci.Text = region.Today_Intensive_Care.ToString();
                                }));
                            }

                            Invoke(new MethodInvoker(() =>
                            {
                                panelSubRegions.Controls.Clear();
                                panelSubRegions.VerticalScroll.Enabled = false;
                                panelSubRegions.HorizontalScroll.Enabled = true;

                                Subregion s = null!;

                                if (region != null)
                                {
                                    List<SubRegion> subRegions = GetSubregions(region);

                                    foreach (var sub in subRegions)
                                    {
                                        s = new Subregion();
                                        s.ChangeName(sub.Name);
                                        s.SetMuertes(sub.Today_New_Deaths.ToString());
                                        s.SetMuertosTotal(sub.Today_Deaths.ToString());
                                        s.SetPositivosTotal(sub.Today_Confirmed.ToString());
                                        s.SetPositivos(sub.Today_New_Confirmed.ToString());
                                        s.SetCurados(sub.Today_New_Recovered.ToString());
                                        s.SetCuradosTotal(sub.Today_Recovered.ToString());
                                        panelSubRegions.Controls.Add(s);
                                    }
                                }
                            }));
                        }
                    }
                }
            }
        }
        private void closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblConnectionStatus_Click(object sender, EventArgs e)
        {

        }
        private void lblProgessBar_Click(object sender, EventArgs e)
        {

        }
        private void lblSelectedCommunity_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dTimeStart.Value.ToString("yyyy-MM-dd");
            if (date == FORBIDDEN_DATE_1 || date == FORBIDDEN_DATE_2)
            {
                dTimeStart.Value = dTimeStart.Value.AddDays(1);
            }

            if (dTimeStart.Value > dTimeFin.Value)
            {
                dTimeStart.Value = dTimeFin.Value.AddDays(-1);
            }

            lblTotalDays.Text = (dTimeFin.Value - dTimeStart.Value).TotalDays.ToString();

            await ShowResultsAsync();
        }
        private void lblTotalPositivos_Click(object sender, EventArgs e)
        {

        }
        private async void dTimeFin_ValueChanged(object sender, EventArgs e)
        {
            string date = dTimeFin.Value.ToString("yyyy-MM-dd");
            if (date == FORBIDDEN_DATE_1 || date == FORBIDDEN_DATE_2)
            {
                dTimeFin.Value = dTimeFin.Value.AddDays(1);
            }

            if(dTimeFin.Value < dTimeStart.Value)
            {
                dTimeFin.Value = dTimeStart.Value.AddDays(1);
            }

            lblTotalDays.Text = (dTimeFin.Value - dTimeStart.Value).TotalDays.ToString();

            await ShowResultsAsync();
        }
        private async void chBoxRango_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRango.Checked)
            {
                lblTotalDays.Text = (dTimeFin.Value - dTimeStart.Value).TotalDays.ToString();
                lblTotalDays.Visible = true;
                lblFinDateTimePicker.Visible = true;
                dTimeFin.Visible = true;
            }
            else
            {
                lblTotalDays.Visible = false;
                lblFinDateTimePicker.Visible = false;
                dTimeFin.Visible = false;
            }
            await ShowResultsAsync();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void cBoxRango_Paint(object sender, PaintEventArgs e)
        {

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