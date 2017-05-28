using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    public partial class PomestiVojnici : Form
    {
        public Zemja zemjaOd;
        public Zemja zemjaVo;

        public PomestiVojnici()
        {
            InitializeComponent();
        }

        public void pocni(Zemja napa, Zemja odb)
        {
            if (napa != null && odb != null)
            {
                zemjaOd = napa;
                zemjaVo = odb;
                lblOdIme.Text = zemjaOd.Ime;
                lblVoIme.Text = zemjaVo.Ime;
                lblOdVojnici.Text = zemjaOd.Vojnici.ToString();
                lblVoVojnici.Text = zemjaVo.Vojnici.ToString();
                numericUpDown1.Maximum = zemjaOd.Vojnici - 1;
            }
        }

        private void azuriraj()
        {
            lblOdVojnici.Text = zemjaOd.Vojnici.ToString();
            lblVoVojnici.Text = zemjaVo.Vojnici.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zemjaOd != null && zemjaVo != null)
            {
                if (zemjaOd.Vojnici > 1)
                {
                    zemjaOd.Vojnici -= (int)numericUpDown1.Value;
                    zemjaVo.Vojnici += (int)numericUpDown1.Value;
                    numericUpDown1.Maximum = zemjaOd.Vojnici - 1;
                    azuriraj();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zemjaOd != null && zemjaVo != null)
            {
                if (zemjaOd.Vojnici > 1)
                {
                    zemjaVo.Vojnici += zemjaOd.Vojnici - 1;
                    zemjaOd.Vojnici -= zemjaOd.Vojnici - 1;
                    azuriraj();
                }
            }
        }

        private void PomestiVojnici_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = MessageBox.Show("Завршивте со поместувањето", "Exit", MessageBoxButtons.OK);
        }
    }
}
