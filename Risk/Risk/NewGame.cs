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
    public partial class NewGame : Form
    {
        public static int count;
        public Igrac igrac1 { get; set; }
        public Igrac igrac2 { get; set; }
        public Igrac igrac3 { get; set; }
        public Igrac igrac4 { get; set; }
        public Igrac igrac5 { get; set; }
        public Igrac igrac6 { get; set; }
        public List<Igrac> igracite = new List<Igrac>();

        public NewGame()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 2)
            {
                lblPlayer3.Visible = false;
                lblColor3.Visible = false;
                lblPlayer4.Visible = false;
                lblColor4.Visible = false;
                lblPlayer5.Visible = false;
                lblColor5.Visible = false;
                lblPlayer6.Visible = false;
                lblColor6.Visible = false;
                tbPlayer3.Visible = false;
                tbPlayer4.Visible = false;
                tbPlayer5.Visible = false;
                tbPlayer6.Visible = false;
            }
            else if(numericUpDown1.Value == 3)
            {
                lblPlayer3.Visible = true;
                lblColor3.Visible = true;
                lblPlayer4.Visible = false;
                lblColor4.Visible = false;
                lblPlayer5.Visible = false;
                lblColor5.Visible = false;
                lblPlayer6.Visible = false;
                lblColor6.Visible = false;
                tbPlayer3.Visible = true;
                tbPlayer4.Visible = false;
                tbPlayer5.Visible = false;
                tbPlayer6.Visible = false;
            } else if(numericUpDown1.Value == 4)
            {
                lblPlayer4.Visible = true;
                lblColor4.Visible = true;
                lblPlayer3.Visible = true;
                lblColor3.Visible = true;
                lblPlayer5.Visible = false;
                lblColor5.Visible = false;
                lblPlayer6.Visible = false;
                lblColor6.Visible = false;
                tbPlayer3.Visible = true;
                tbPlayer4.Visible = true;
                tbPlayer5.Visible = false;
                tbPlayer6.Visible = false;
            } else if(numericUpDown1.Value == 5)
            {
                lblPlayer4.Visible = true;
                lblColor4.Visible = true;
                lblPlayer3.Visible = true;
                lblColor3.Visible = true;
                lblPlayer5.Visible = true;
                lblColor5.Visible = true;
                lblPlayer6.Visible = false;
                lblColor6.Visible = false;
                tbPlayer3.Visible = true;
                tbPlayer4.Visible = true;
                tbPlayer5.Visible = true;
                tbPlayer6.Visible = false;
            } else if(numericUpDown1.Value == 6)
            {
                lblPlayer4.Visible = true;
                lblColor4.Visible = true;
                lblPlayer3.Visible = true;
                lblColor3.Visible = true;
                lblPlayer5.Visible = true;
                lblColor5.Visible = true;
                lblPlayer6.Visible = true;
                lblColor6.Visible = true;
                tbPlayer3.Visible = true;
                tbPlayer4.Visible = true;
                tbPlayer5.Visible = true;
                tbPlayer6.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            MessageBox.Show("Нова игра не е креирана.");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                igrac1 = new Igrac(tbPlayer1.Text.Trim(), Color.Red);
                igrac2 = new Igrac(tbPlayer2.Text.Trim(), Color.Green);
                count = (int)numericUpDown1.Value;
                igracite.Add(igrac1);
                igracite.Add(igrac2);
                if (numericUpDown1.Value >= 3)
                {
                    igrac3 = new Igrac(tbPlayer3.Text.Trim(), Color.Yellow);
                    igracite.Add(igrac3);
                }
                if (numericUpDown1.Value >= 4)
                {
                    igrac4 = new Igrac(tbPlayer4.Text.Trim(), Color.Blue);
                    igracite.Add(igrac4);
                }
                if (numericUpDown1.Value >= 5)
                {
                    igrac5 = new Igrac(tbPlayer5.Text.Trim(), Color.Brown);
                    igracite.Add(igrac5);
                }
                if (numericUpDown1.Value == 6)
                {
                    igrac6 = new Igrac(tbPlayer6.Text.Trim(), Color.Purple);
                    igracite.Add(igrac6);
                }
                DialogResult = DialogResult.OK;
                MessageBox.Show("Креиравте нова игра.", "Нова игра", MessageBoxButtons.OK);
            }
        }
        
        private void tbPlayer1_Validating(object sender, CancelEventArgs e)
        {
            if(tbPlayer1.Text.Trim().Length <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPlayer1,"Внеси име за Играч1");
            } else
            {
                errorProvider1.SetError(tbPlayer1, "");
            }
        }

        private void tbPlayer2_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer2.Text.Trim().Length <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPlayer2, "Внеси име за Играч2");
            }
            else
            {
                errorProvider1.SetError(tbPlayer2, "");
            }
        }

        private void tbPlayer3_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDown1.Value >= 3)
            {
                if (tbPlayer3.Text.Trim().Length <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPlayer3, "Внеси име за Играч3");
                }
                else
                {
                    errorProvider1.SetError(tbPlayer3, "");
                }
            }
        }

        private void tbPlayer4_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value >= 4)
            {
                if (tbPlayer4.Text.Trim().Length <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPlayer4, "Внеси име за Играч4");
                }
                else
                {
                    errorProvider1.SetError(tbPlayer4, "");
                }
            }
        }

        private void tbPlayer5_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value >= 5)
            {
                if (tbPlayer5.Text.Trim().Length <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPlayer5, "Внеси име за Играч5");
                }
                else
                {
                    errorProvider1.SetError(tbPlayer5, "");
                }
            }
        }

        private void tbPlayer6_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown1.Value >= 6)
            {
                if (tbPlayer6.Text.Trim().Length <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPlayer6, "Внеси име за Играч6");
                }
                else
                {
                    errorProvider1.SetError(tbPlayer6, "");
                }
            }
        }
    }
}
