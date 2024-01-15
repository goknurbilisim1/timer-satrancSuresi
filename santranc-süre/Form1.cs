using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santranc_süre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sureBeyaz = 10;
        int sureSiyah = 10;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start();
        }

        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            if (sureBeyaz > 0)
            {
                sureBeyaz--;
                lblBeyaz.Text =$"{sureBeyaz} saniye kaldı";
            }
            else
            {
                timerBeyaz.Stop();
                MessageBox.Show("Siyah kazandı");

;            }
           
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timerBeyaz.Stop();
            timerSiyah.Start();
        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
            if(sureSiyah > 0)
            {
                sureSiyah--;
                lblSiyah.Text = $"{sureSiyah}saniye kaldı";
            }
            else
            {
                timerSiyah.Stop();
                MessageBox.Show("Beyaz kazandı");
            }
           
           
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            timerSiyah.Stop();
            timerBeyaz.Start();
        }
    }
}
