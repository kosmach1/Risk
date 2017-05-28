using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    public class Zemja
    {
        public string Ime { get; set; }
        public Igrac ZemjoPosednik { get; set; }
        public int Vojnici { get; set; }
        public List<Zemja> Sosedi;
        public Label labela { get; set; }
        public bool isSelected { get; set; }

        public Zemja()
        {
            Ime = "";
            ZemjoPosednik = null;
            Vojnici = 0;
            isSelected = false;
        }

        public Zemja(string Ime, int Vojnici)
        {
            this.Ime = Ime;
            this.ZemjoPosednik = null;
            this.Vojnici = Vojnici;
            isSelected = false;
            Sosedi = new List<Zemja>();
        }

        public void addSosed(Zemja z)
        {
            if(z != null)
            {
                Sosedi.Add(z);
            }
        }



        public void remSosed(Zemja z)
        {
            if (z != null)
            {
                Sosedi.Remove(z);
            }
        }


        public override string ToString()
        {
            return string.Format("{0}",Ime);
        }
    }
}
