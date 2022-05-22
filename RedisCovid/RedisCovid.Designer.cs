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
            this.labelResult = new System.Windows.Forms.Label();
            this.btnObtenerTaburete = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.minimizeForm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalParsedFiles = new System.Windows.Forms.Label();
            this.lblProgessBar = new System.Windows.Forms.Label();
            this.prBarParse = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeForm)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(185, 30);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(38, 15);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "label1";
            // 
            // btnObtenerTaburete
            // 
            this.btnObtenerTaburete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObtenerTaburete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnObtenerTaburete.Location = new System.Drawing.Point(201, 357);
            this.btnObtenerTaburete.Name = "btnObtenerTaburete";
            this.btnObtenerTaburete.Size = new System.Drawing.Size(151, 41);
            this.btnObtenerTaburete.TabIndex = 6;
            this.btnObtenerTaburete.Text = "Sacar chorro";
            this.btnObtenerTaburete.UseVisualStyleBackColor = false;
            this.btnObtenerTaburete.Click += new System.EventHandler(this.btnObtenerTaburete_Click);
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
            this.btnParse.Text = "PARSEAR DATOS";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 23);
            this.dateTimePicker1.TabIndex = 9;
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
            this.pictureBox2.Image = global::RedisCovid.Properties.Resources.Covid_icon;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblConnectionStatus);
            this.panel3.Controls.Add(this.labelResult);
            this.panel3.Controls.Add(this.btnObtenerTaburete);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 564);
            this.panel3.TabIndex = 15;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(136)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResultMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnObtenerTaburete;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.PictureBox minimizeForm;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar prBarParse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProgessBar;
        private System.Windows.Forms.Label lblTotalParsedFiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
