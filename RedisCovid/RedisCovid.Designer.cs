namespace RedisCovid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dTimeStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.minimizeForm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxRango = new System.Windows.Forms.Panel();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.panelSubRegions = new System.Windows.Forms.FlowLayoutPanel();
            this.chBoxRango = new System.Windows.Forms.CheckBox();
            this.lblFinDateTimePicker = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dTimeFin = new System.Windows.Forms.DateTimePicker();
            this.lblTotalUciInfo = new System.Windows.Forms.Label();
            this.lblTotalUci = new System.Windows.Forms.Label();
            this.lblTotalIngresadosInfo = new System.Windows.Forms.Label();
            this.lblTotalIngresados = new System.Windows.Forms.Label();
            this.lblUciInfo = new System.Windows.Forms.Label();
            this.lblUci = new System.Windows.Forms.Label();
            this.lblIngresadosInfo = new System.Windows.Forms.Label();
            this.lblIngresados = new System.Windows.Forms.Label();
            this.lblTotalMuertesInfo = new System.Windows.Forms.Label();
            this.lblTotalMuertes = new System.Windows.Forms.Label();
            this.lblTotalPositivosInfo = new System.Windows.Forms.Label();
            this.lblTotalPositivos = new System.Windows.Forms.Label();
            this.lblMuertesInfo = new System.Windows.Forms.Label();
            this.lblMuertes = new System.Windows.Forms.Label();
            this.lblPositivosInfo = new System.Windows.Forms.Label();
            this.lblSelectedCommunity = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalParsedFiles = new System.Windows.Forms.Label();
            this.lblProgessBar = new System.Windows.Forms.Label();
            this.prBarParse = new System.Windows.Forms.ProgressBar();
            this.lblPositivos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeForm)).BeginInit();
            this.panel2.SuspendLayout();
            this.cBoxRango.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnectionStatus.Location = new System.Drawing.Point(3, 506);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(73, 13);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "COMUNIDAD";
            this.lblConnectionStatus.Click += new System.EventHandler(this.lblConnectionStatus_Click);
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.AutoSize = true;
            this.lblResultMessage.Location = new System.Drawing.Point(47, 174);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(0, 15);
            this.lblResultMessage.TabIndex = 2;
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnParse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnParse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnParse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParse.ForeColor = System.Drawing.Color.LightGray;
            this.btnParse.Location = new System.Drawing.Point(11, 6);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(135, 30);
            this.btnParse.TabIndex = 7;
            this.btnParse.Text = "IMPORTAR DATOS";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            // 
            // dTimeStart
            // 
            this.dTimeStart.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dTimeStart.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dTimeStart.Location = new System.Drawing.Point(3, 310);
            this.dTimeStart.MinDate = new System.DateTime(2020, 1, 23, 0, 0, 0, 0);
            this.dTimeStart.Name = "dTimeStart";
            this.dTimeStart.Size = new System.Drawing.Size(227, 23);
            this.dTimeStart.TabIndex = 9;
            this.dTimeStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.appName);
            this.panel1.Controls.Add(this.closeForm);
            this.panel1.Controls.Add(this.minimizeForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 36);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RedisCovid.Properties.Resources.CovidIcon;
            this.pictureBox2.Location = new System.Drawing.Point(8, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appName.Location = new System.Drawing.Point(47, 6);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(130, 25);
            this.appName.TabIndex = 2;
            this.appName.Text = "Redis-Covid";
            // 
            // closeForm
            // 
            this.closeForm.Image = global::RedisCovid.Properties.Resources.Close_Button;
            this.closeForm.Location = new System.Drawing.Point(1370, 6);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(25, 25);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeForm.TabIndex = 1;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // minimizeForm
            // 
            this.minimizeForm.Image = global::RedisCovid.Properties.Resources.Minimize_Button;
            this.minimizeForm.Location = new System.Drawing.Point(1333, 6);
            this.minimizeForm.Name = "minimizeForm";
            this.minimizeForm.Size = new System.Drawing.Size(25, 25);
            this.minimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeForm.TabIndex = 0;
            this.minimizeForm.TabStop = false;
            this.minimizeForm.Click += new System.EventHandler(this.minimizeForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(597, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 564);
            this.panel2.TabIndex = 14;
            // 
            // cBoxRango
            // 
            this.cBoxRango.BackColor = System.Drawing.Color.LightGray;
            this.cBoxRango.Controls.Add(this.lblTotalDays);
            this.cBoxRango.Controls.Add(this.panelSubRegions);
            this.cBoxRango.Controls.Add(this.chBoxRango);
            this.cBoxRango.Controls.Add(this.lblFinDateTimePicker);
            this.cBoxRango.Controls.Add(this.label9);
            this.cBoxRango.Controls.Add(this.dTimeFin);
            this.cBoxRango.Controls.Add(this.lblTotalUciInfo);
            this.cBoxRango.Controls.Add(this.lblTotalUci);
            this.cBoxRango.Controls.Add(this.lblTotalIngresadosInfo);
            this.cBoxRango.Controls.Add(this.lblTotalIngresados);
            this.cBoxRango.Controls.Add(this.lblUciInfo);
            this.cBoxRango.Controls.Add(this.lblUci);
            this.cBoxRango.Controls.Add(this.lblIngresadosInfo);
            this.cBoxRango.Controls.Add(this.lblIngresados);
            this.cBoxRango.Controls.Add(this.lblTotalMuertesInfo);
            this.cBoxRango.Controls.Add(this.lblTotalMuertes);
            this.cBoxRango.Controls.Add(this.lblTotalPositivosInfo);
            this.cBoxRango.Controls.Add(this.lblTotalPositivos);
            this.cBoxRango.Controls.Add(this.lblMuertesInfo);
            this.cBoxRango.Controls.Add(this.lblMuertes);
            this.cBoxRango.Controls.Add(this.lblPositivosInfo);
            this.cBoxRango.Controls.Add(this.lblSelectedCommunity);
            this.cBoxRango.Controls.Add(this.panel4);
            this.cBoxRango.Controls.Add(this.dTimeStart);
            this.cBoxRango.Controls.Add(this.lblConnectionStatus);
            this.cBoxRango.Controls.Add(this.lblPositivos);
            this.cBoxRango.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBoxRango.Location = new System.Drawing.Point(0, 36);
            this.cBoxRango.Name = "cBoxRango";
            this.cBoxRango.Size = new System.Drawing.Size(597, 564);
            this.cBoxRango.TabIndex = 15;
            this.cBoxRango.Paint += new System.Windows.Forms.PaintEventHandler(this.cBoxRango_Paint);
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDays.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalDays.Location = new System.Drawing.Point(467, 310);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(124, 20);
            this.lblTotalDays.TabIndex = 42;
            this.lblTotalDays.Text = "0 DÍAS";
            this.lblTotalDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSubRegions
            // 
            this.panelSubRegions.AutoScroll = true;
            this.panelSubRegions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubRegions.Location = new System.Drawing.Point(0, 342);
            this.panelSubRegions.Name = "panelSubRegions";
            this.panelSubRegions.Size = new System.Drawing.Size(597, 180);
            this.panelSubRegions.TabIndex = 41;
            // 
            // chBoxRango
            // 
            this.chBoxRango.AutoSize = true;
            this.chBoxRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chBoxRango.Location = new System.Drawing.Point(489, 283);
            this.chBoxRango.Name = "chBoxRango";
            this.chBoxRango.Size = new System.Drawing.Size(81, 24);
            this.chBoxRango.TabIndex = 40;
            this.chBoxRango.TabStop = false;
            this.chBoxRango.Text = "Rango";
            this.chBoxRango.UseVisualStyleBackColor = true;
            this.chBoxRango.CheckedChanged += new System.EventHandler(this.chBoxRango_CheckedChanged);
            // 
            // lblFinDateTimePicker
            // 
            this.lblFinDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFinDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinDateTimePicker.ForeColor = System.Drawing.Color.LightGray;
            this.lblFinDateTimePicker.Location = new System.Drawing.Point(234, 285);
            this.lblFinDateTimePicker.Name = "lblFinDateTimePicker";
            this.lblFinDateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.lblFinDateTimePicker.TabIndex = 29;
            this.lblFinDateTimePicker.Text = "FIN";
            this.lblFinDateTimePicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinDateTimePicker.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(1, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "INICIO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dTimeFin
            // 
            this.dTimeFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dTimeFin.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dTimeFin.Location = new System.Drawing.Point(234, 310);
            this.dTimeFin.MinDate = new System.DateTime(2020, 1, 23, 0, 0, 0, 0);
            this.dTimeFin.Name = "dTimeFin";
            this.dTimeFin.Size = new System.Drawing.Size(227, 23);
            this.dTimeFin.TabIndex = 27;
            this.dTimeFin.ValueChanged += new System.EventHandler(this.dTimeFin_ValueChanged);
            // 
            // lblTotalUciInfo
            // 
            this.lblTotalUciInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalUciInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUciInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalUciInfo.Location = new System.Drawing.Point(326, 240);
            this.lblTotalUciInfo.Name = "lblTotalUciInfo";
            this.lblTotalUciInfo.Size = new System.Drawing.Size(135, 30);
            this.lblTotalUciInfo.TabIndex = 25;
            this.lblTotalUciInfo.Text = "TOTAL";
            this.lblTotalUciInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalUci
            // 
            this.lblTotalUci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblTotalUci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalUci.ForeColor = System.Drawing.Color.Black;
            this.lblTotalUci.Location = new System.Drawing.Point(461, 240);
            this.lblTotalUci.Name = "lblTotalUci";
            this.lblTotalUci.Size = new System.Drawing.Size(135, 30);
            this.lblTotalUci.TabIndex = 26;
            this.lblTotalUci.Text = "0";
            this.lblTotalUci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalIngresadosInfo
            // 
            this.lblTotalIngresadosInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalIngresadosInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIngresadosInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalIngresadosInfo.Location = new System.Drawing.Point(326, 180);
            this.lblTotalIngresadosInfo.Name = "lblTotalIngresadosInfo";
            this.lblTotalIngresadosInfo.Size = new System.Drawing.Size(135, 30);
            this.lblTotalIngresadosInfo.TabIndex = 23;
            this.lblTotalIngresadosInfo.Text = "TOTAL";
            this.lblTotalIngresadosInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalIngresados
            // 
            this.lblTotalIngresados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblTotalIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIngresados.ForeColor = System.Drawing.Color.Black;
            this.lblTotalIngresados.Location = new System.Drawing.Point(461, 180);
            this.lblTotalIngresados.Name = "lblTotalIngresados";
            this.lblTotalIngresados.Size = new System.Drawing.Size(135, 30);
            this.lblTotalIngresados.TabIndex = 24;
            this.lblTotalIngresados.Text = "0";
            this.lblTotalIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUciInfo
            // 
            this.lblUciInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUciInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUciInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblUciInfo.Location = new System.Drawing.Point(0, 240);
            this.lblUciInfo.Name = "lblUciInfo";
            this.lblUciInfo.Size = new System.Drawing.Size(191, 30);
            this.lblUciInfo.TabIndex = 21;
            this.lblUciInfo.Text = "EN UCI";
            this.lblUciInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUci
            // 
            this.lblUci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblUci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUci.ForeColor = System.Drawing.Color.Black;
            this.lblUci.Location = new System.Drawing.Point(191, 240);
            this.lblUci.Name = "lblUci";
            this.lblUci.Size = new System.Drawing.Size(135, 30);
            this.lblUci.TabIndex = 22;
            this.lblUci.Text = "0";
            this.lblUci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIngresadosInfo
            // 
            this.lblIngresadosInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblIngresadosInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresadosInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblIngresadosInfo.Location = new System.Drawing.Point(0, 180);
            this.lblIngresadosInfo.Name = "lblIngresadosInfo";
            this.lblIngresadosInfo.Size = new System.Drawing.Size(191, 30);
            this.lblIngresadosInfo.TabIndex = 19;
            this.lblIngresadosInfo.Text = "INGRESADOS";
            this.lblIngresadosInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngresados
            // 
            this.lblIngresados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblIngresados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresados.ForeColor = System.Drawing.Color.Black;
            this.lblIngresados.Location = new System.Drawing.Point(191, 180);
            this.lblIngresados.Name = "lblIngresados";
            this.lblIngresados.Size = new System.Drawing.Size(135, 30);
            this.lblIngresados.TabIndex = 20;
            this.lblIngresados.Text = "0";
            this.lblIngresados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMuertesInfo
            // 
            this.lblTotalMuertesInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalMuertesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMuertesInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalMuertesInfo.Location = new System.Drawing.Point(326, 120);
            this.lblTotalMuertesInfo.Name = "lblTotalMuertesInfo";
            this.lblTotalMuertesInfo.Size = new System.Drawing.Size(135, 30);
            this.lblTotalMuertesInfo.TabIndex = 17;
            this.lblTotalMuertesInfo.Text = "TOTAL";
            this.lblTotalMuertesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMuertes
            // 
            this.lblTotalMuertes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblTotalMuertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMuertes.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMuertes.Location = new System.Drawing.Point(461, 120);
            this.lblTotalMuertes.Name = "lblTotalMuertes";
            this.lblTotalMuertes.Size = new System.Drawing.Size(135, 30);
            this.lblTotalMuertes.TabIndex = 18;
            this.lblTotalMuertes.Text = "0";
            this.lblTotalMuertes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPositivosInfo
            // 
            this.lblTotalPositivosInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTotalPositivosInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPositivosInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalPositivosInfo.Location = new System.Drawing.Point(326, 60);
            this.lblTotalPositivosInfo.Name = "lblTotalPositivosInfo";
            this.lblTotalPositivosInfo.Size = new System.Drawing.Size(135, 30);
            this.lblTotalPositivosInfo.TabIndex = 15;
            this.lblTotalPositivosInfo.Text = "TOTAL";
            this.lblTotalPositivosInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPositivos
            // 
            this.lblTotalPositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblTotalPositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPositivos.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPositivos.Location = new System.Drawing.Point(461, 60);
            this.lblTotalPositivos.Name = "lblTotalPositivos";
            this.lblTotalPositivos.Size = new System.Drawing.Size(135, 30);
            this.lblTotalPositivos.TabIndex = 16;
            this.lblTotalPositivos.Text = "0";
            this.lblTotalPositivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPositivos.Click += new System.EventHandler(this.lblTotalPositivos_Click);
            // 
            // lblMuertesInfo
            // 
            this.lblMuertesInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMuertesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMuertesInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblMuertesInfo.Location = new System.Drawing.Point(0, 120);
            this.lblMuertesInfo.Name = "lblMuertesInfo";
            this.lblMuertesInfo.Size = new System.Drawing.Size(191, 30);
            this.lblMuertesInfo.TabIndex = 13;
            this.lblMuertesInfo.Text = "MUERTES";
            this.lblMuertesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMuertes
            // 
            this.lblMuertes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblMuertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMuertes.ForeColor = System.Drawing.Color.Black;
            this.lblMuertes.Location = new System.Drawing.Point(191, 120);
            this.lblMuertes.Name = "lblMuertes";
            this.lblMuertes.Size = new System.Drawing.Size(135, 30);
            this.lblMuertes.TabIndex = 14;
            this.lblMuertes.Text = "0";
            this.lblMuertes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPositivosInfo
            // 
            this.lblPositivosInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPositivosInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPositivosInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblPositivosInfo.Location = new System.Drawing.Point(0, 60);
            this.lblPositivosInfo.Name = "lblPositivosInfo";
            this.lblPositivosInfo.Size = new System.Drawing.Size(191, 30);
            this.lblPositivosInfo.TabIndex = 11;
            this.lblPositivosInfo.Text = "POSITIVOS";
            this.lblPositivosInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedCommunity
            // 
            this.lblSelectedCommunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSelectedCommunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedCommunity.ForeColor = System.Drawing.Color.LightGray;
            this.lblSelectedCommunity.Location = new System.Drawing.Point(0, 16);
            this.lblSelectedCommunity.Name = "lblSelectedCommunity";
            this.lblSelectedCommunity.Size = new System.Drawing.Size(597, 20);
            this.lblSelectedCommunity.TabIndex = 10;
            this.lblSelectedCommunity.Text = "SELECCIONE UNA COMUNIDAD";
            this.lblSelectedCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectedCommunity.Click += new System.EventHandler(this.lblSelectedCommunity_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(116)))), ((int)(((byte)(135)))));
            this.panel4.Controls.Add(this.lblTotalParsedFiles);
            this.panel4.Controls.Add(this.lblProgessBar);
            this.panel4.Controls.Add(this.prBarParse);
            this.panel4.Controls.Add(this.btnParse);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 522);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 42);
            this.panel4.TabIndex = 9;
            // 
            // lblTotalParsedFiles
            // 
            this.lblTotalParsedFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalParsedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalParsedFiles.ForeColor = System.Drawing.Color.Black;
            this.lblTotalParsedFiles.Location = new System.Drawing.Point(152, 6);
            this.lblTotalParsedFiles.Name = "lblTotalParsedFiles";
            this.lblTotalParsedFiles.Size = new System.Drawing.Size(390, 30);
            this.lblTotalParsedFiles.TabIndex = 11;
            this.lblTotalParsedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgessBar
            // 
            this.lblProgessBar.BackColor = System.Drawing.Color.Transparent;
            this.lblProgessBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgessBar.ForeColor = System.Drawing.Color.Black;
            this.lblProgessBar.Location = new System.Drawing.Point(548, 6);
            this.lblProgessBar.Name = "lblProgessBar";
            this.lblProgessBar.Size = new System.Drawing.Size(43, 30);
            this.lblProgessBar.TabIndex = 10;
            this.lblProgessBar.Text = "0%";
            this.lblProgessBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgessBar.Click += new System.EventHandler(this.lblProgessBar_Click);
            // 
            // prBarParse
            // 
            this.prBarParse.Location = new System.Drawing.Point(152, 6);
            this.prBarParse.Name = "prBarParse";
            this.prBarParse.Size = new System.Drawing.Size(390, 30);
            this.prBarParse.TabIndex = 8;
            // 
            // lblPositivos
            // 
            this.lblPositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.lblPositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPositivos.ForeColor = System.Drawing.Color.Black;
            this.lblPositivos.Location = new System.Drawing.Point(191, 60);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(135, 30);
            this.lblPositivos.TabIndex = 12;
            this.lblPositivos.Text = "0";
            this.lblPositivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.cBoxRango);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResultMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redis Covid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeForm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.cBoxRango.ResumeLayout(false);
            this.cBoxRango.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dTimeStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.PictureBox minimizeForm;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel cBoxRango;
        private System.Windows.Forms.ProgressBar prBarParse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProgessBar;
        private System.Windows.Forms.Label lblTotalParsedFiles;
        private System.Windows.Forms.Label lblSelectedCommunity;
        private System.Windows.Forms.Label lblPositivosInfo;
        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.Label lblTotalMuertesInfo;
        private System.Windows.Forms.Label lblTotalMuertes;
        private System.Windows.Forms.Label lblTotalPositivosInfo;
        private System.Windows.Forms.Label lblTotalPositivos;
        private System.Windows.Forms.Label lblMuertesInfo;
        private System.Windows.Forms.Label lblMuertes;
        private System.Windows.Forms.Label lblTotalUciInfo;
        private System.Windows.Forms.Label lblTotalUci;
        private System.Windows.Forms.Label lblTotalIngresadosInfo;
        private System.Windows.Forms.Label lblTotalIngresados;
        private System.Windows.Forms.Label lblUciInfo;
        private System.Windows.Forms.Label lblUci;
        private System.Windows.Forms.Label lblIngresadosInfo;
        private System.Windows.Forms.Label lblIngresados;
        private System.Windows.Forms.Label lblFinDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTimeFin;
        private System.Windows.Forms.CheckBox chBoxRango;
        private System.Windows.Forms.FlowLayoutPanel panelSubRegions;
        private System.Windows.Forms.Label lblTotalDays;
    }
}
