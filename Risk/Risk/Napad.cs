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
    public partial class Napad : Form
    {
        public Zemja napagjac;
        public Zemja odbrana;
        public Igrac izgubi;
        private Random rand;

        public Napad()
        {
            InitializeComponent();
            rand = new Random();
        }


        public void pocni(Zemja napa, Zemja odb)
        {
            napagjac = napa;
            odbrana = odb;
            if (napagjac != null && odb != null)
            {
                lblNapadIme.Text = napagjac.Ime;
                lblOdbranaIme.Text = odbrana.Ime;
                lblNapadVojnici.Text = napagjac.Vojnici.ToString();
                lblOdbranaVojnici.Text = odbrana.Vojnici.ToString();
            }
        }

        private void azuriraj()
        {
            lblNapadVojnici.Text = napagjac.Vojnici.ToString();
            lblOdbranaVojnici.Text = odbrana.Vojnici.ToString();
        }

        private int najgolemBroj(int[] broevi)
        {
            int najg = 0;
            foreach(int i in broevi)
            {
                if(najg < i)
                {
                    najg = i;
                }
            }
            return najg;
        }

        private void napadni()
        {
            int kockaNapad1 = 0;
            int kockaNapad2 = 0;
            int kockaNapad3 = 0;
            int kockaOdbrana1 = 0;
            int kockaOdbrana2 = 0;
            int[] broeviNapad = new int[3];
            int[] broeviOdbrana = new int[2];

            if (napagjac != null && odbrana != null)
            {
                if (napagjac.Vojnici == 2)
                {
                    kockaNapad1 = rand.Next(6);
                    kockaOdbrana1 = rand.Next(6);
                    broeviNapad[0] = kockaNapad1;
                    broeviOdbrana[0] = kockaOdbrana1;
                    if (odbrana.Vojnici == 1)
                    {
                        if (kockaOdbrana1 > kockaNapad1 || (kockaNapad1 == kockaOdbrana1))
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                        else
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                    }
                    else if (odbrana.Vojnici > 1)
                    {
                        kockaOdbrana2 = rand.Next(6);
                        broeviOdbrana[1] = kockaOdbrana2;
                        if (najgolemBroj(broeviOdbrana) > kockaNapad1 || (najgolemBroj(broeviOdbrana) == kockaNapad1))
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                        else
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                    }
                }
                else if (napagjac.Vojnici == 3)
                {
                    kockaNapad1 = rand.Next(6);
                    kockaOdbrana1 = rand.Next(6);
                    kockaNapad2 = rand.Next(6);
                    broeviNapad[0] = kockaNapad1;
                    broeviNapad[1] = kockaNapad2;
                    broeviOdbrana[0] = kockaOdbrana1;
                    if (odbrana.Vojnici == 1)
                    {
                        if (najgolemBroj(broeviNapad) > najgolemBroj(broeviOdbrana))
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                        else
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                    }
                    else if (odbrana.Vojnici > 1)
                    {
                        kockaOdbrana2 = rand.Next(6);
                        broeviOdbrana[1] = kockaOdbrana2;
                        if (najgolemBroj(broeviNapad) > najgolemBroj(broeviOdbrana))
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                        else
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                    }
                }
                else if (napagjac.Vojnici > 3)
                {
                    kockaNapad1 = rand.Next(6);
                    kockaOdbrana1 = rand.Next(6);
                    kockaNapad2 = rand.Next(6);
                    kockaNapad3 = rand.Next(6);
                    broeviNapad[0] = kockaNapad1;
                    broeviNapad[1] = kockaNapad2;
                    broeviNapad[2] = kockaNapad3;
                    broeviOdbrana[0] = kockaOdbrana1;
                    if (odbrana.Vojnici == 1)
                    {
                        if (najgolemBroj(broeviNapad) > najgolemBroj(broeviOdbrana))
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                        else
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                    }
                    else if (odbrana.Vojnici > 1)
                    {
                        kockaOdbrana2 = rand.Next(6);
                        broeviOdbrana[1] = kockaOdbrana2;
                        if (najgolemBroj(broeviNapad) > najgolemBroj(broeviOdbrana))
                        {
                            odbrana.ZemjoPosednik.Vojnici--;
                            odbrana.Vojnici--;
                        }
                        else
                        {
                            napagjac.ZemjoPosednik.Vojnici--;
                            napagjac.Vojnici--;
                        }
                    }
                }
            }
        }

        private void btnNapad_Click(object sender, EventArgs e)
        {   if (napagjac != null && odbrana != null)
            {
                if (napagjac.Vojnici > 1 && odbrana.Vojnici > 0)
                {
                    napadni();
                    azuriraj();
                    if (odbrana.Vojnici == 0)
                    {
                        PomestiVojnici pv = new PomestiVojnici();
                        MessageBox.Show("Ја освоивте територијата!");
                        odbrana.ZemjoPosednik.BrojTeritorii--;
                        odbrana.ZemjoPosednik.izbrisiKontroliranaTeritorija(odbrana);
                        if (odbrana.ZemjoPosednik.BrojTeritorii == 0)
                        {
                            string str = "Играчот " + odbrana.ZemjoPosednik.Ime + " изгуби";
                            MessageBox.Show(str);
                            izgubi = odbrana.ZemjoPosednik;
                        }

                        odbrana.ZemjoPosednik = napagjac.ZemjoPosednik;
                        odbrana.ZemjoPosednik.addKontroliraniTeritorii(odbrana);
                        odbrana.ZemjoPosednik.BrojTeritorii++;
                        odbrana.labela.BackColor = odbrana.ZemjoPosednik.Boja;
                        pv.pocni(napagjac, odbrana);
                        pv.ShowDialog();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Не успеавте да ја освоите територијата");
                    Close();
                }
            }
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (napagjac != null && odbrana != null)
            {
                while (napagjac.Vojnici > 1 && odbrana.Vojnici > 0)
                {
                    napadni();
                    azuriraj();
                    if (odbrana.Vojnici == 0)
                    {
                        PomestiVojnici pv = new PomestiVojnici();
                        MessageBox.Show("Ја освоивте територијата!");
                        odbrana.ZemjoPosednik.BrojTeritorii--;
                        odbrana.ZemjoPosednik.izbrisiKontroliranaTeritorija(odbrana);
                        if(odbrana.ZemjoPosednik.BrojTeritorii == 0)
                        {
                            string str = "Играчот " + odbrana.ZemjoPosednik.Ime + " изгуби";
                            MessageBox.Show(str);
                            izgubi = odbrana.ZemjoPosednik;
                        }
                        odbrana.ZemjoPosednik = napagjac.ZemjoPosednik;
                        odbrana.ZemjoPosednik.addKontroliraniTeritorii(odbrana);
                        odbrana.ZemjoPosednik.BrojTeritorii++;
                        odbrana.labela.BackColor = odbrana.ZemjoPosednik.Boja;
                        pv.pocni(napagjac, odbrana);
                        pv.ShowDialog();
                        Close();
                        break;
                    }
                }
                if(napagjac.ZemjoPosednik != odbrana.ZemjoPosednik)
                {
                        MessageBox.Show("Не успеавте да ја освоите територијата");
                        Close();
                }
            }
        }
    }
}
