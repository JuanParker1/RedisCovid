using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisCovid
{
    public partial class Subregion : UserControl
    {
        public Subregion()
        {
            InitializeComponent();
            lblTotalCurados.Text = "---";
            lblTotalMuertes.Text = "---";
            lblTotalPositivos.Text = "---";
        }

        public void ChangeName(string name)
        {
            lblRegionName.Text = name;
        }

        private void Subregion_Load(object sender, EventArgs e)
        {

        }

        private void lblRebionName_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetMuertes(string muertes) { lblMuertes.Text = muertes; }
        public void SetPositivos(string positivos) { lblPositivos.Text = positivos; }
        public void SetCurados(string curados) { lblCurados.Text = curados; }
        public void SetMuertosTotal(string muertesTotales) { lblTotalMuertes.Text = muertesTotales; }
        public void SetPositivosTotal(string positivosTotales) { lblTotalPositivos.Text = positivosTotales; }
        public void SetCuradosTotal(string curadosTotales) { lblTotalCurados.Text = curadosTotales; }
    }
}
