using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Kontinent
    {
        public List<Zemja> Evropa;
        public List<Zemja> Azija;
        public List<Zemja> SevernaAmerika;
        public List<Zemja> JuznaAmerika;
        public List<Zemja> Avstralija;
        public List<Zemja> Afrika;

        public Kontinent()
        {
            Evropa = new List<Zemja>();
            Azija = new List<Zemja>();
            SevernaAmerika = new List<Zemja>();
            JuznaAmerika = new List<Zemja>();
            Avstralija = new List<Zemja>();
            Afrika = new List<Zemja>();
        }

        public void addZemjaVoEvropa(Zemja z)
        {
            if(z != null)
            {
                Evropa.Add(z);
            }
        }

        public void addZemjaVoAzija(Zemja z)
        {
            if (z != null)
            {
                Azija.Add(z);
            }
        }

        public void addZemjaVoSevernaAmerika(Zemja z)
        {
            if (z != null)
            {
               SevernaAmerika.Add(z);
            }
        }

        public void addZemjaVoJuznaAmerika(Zemja z)
        {
            if (z != null)
            {
                JuznaAmerika.Add(z);
            }
        }

        public void addZemjaVoAfrika(Zemja z)
        {
            if (z != null)
            {
                Afrika.Add(z);
            }
        }

        public void addZemjaVoAvstralija(Zemja z)
        {
            if (z != null)
            {
                Avstralija.Add(z);
            }
        }
    }
}
