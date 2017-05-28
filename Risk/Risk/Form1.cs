using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Risk
{
    public enum GameMode
    {
        ConquerAll,
        Mission
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NamestiMapa();
            btnNapad.Enabled = false;
            btnPomestVojnici.Enabled = false;
        }

        

        private List<Zemja> zemji = new List<Zemja>();
        private List<Igrac> players = new List<Igrac>();
        private Kontinent kontinenti = new Kontinent();
        public const int brojNaZemji = 42;
        public Igrac dajIzguben;
        public Random rand = new Random();
       

        public void NamestiMapa()
        {
            zemji.Add(new Zemja("Alaska",0));
            zemji.Add(new Zemja("Alberta", 0));
            zemji.Add(new Zemja("Central America", 0));
            zemji.Add(new Zemja("Eastern United States", 0));
            zemji.Add(new Zemja("Greenland", 0));
            zemji.Add(new Zemja("Northwest Territory", 0));
            zemji.Add(new Zemja("Ontario", 0));
            zemji.Add(new Zemja("Quebec", 0));
            zemji.Add(new Zemja("Western United States", 0));
            zemji.Add(new Zemja("Argentina", 0));
            zemji.Add(new Zemja("Brazil", 0));
            zemji.Add(new Zemja("Peru", 0));
            zemji.Add(new Zemja("Venezuela", 0));
            zemji.Add(new Zemja("Great Britain", 0));
            zemji.Add(new Zemja("Iceland", 0));
            zemji.Add(new Zemja("Northern Europe", 0));
            zemji.Add(new Zemja("Scandinavia", 0));
            zemji.Add(new Zemja("Southern Europe", 0));
            zemji.Add(new Zemja("Ukraine", 0));
            zemji.Add(new Zemja("Western Europe", 0));
            zemji.Add(new Zemja("Congo", 0));
            zemji.Add(new Zemja("East Africa", 0));
            zemji.Add(new Zemja("Egypt", 0));
            zemji.Add(new Zemja("Madagascar", 0));
            zemji.Add(new Zemja("North Africa", 0));
            zemji.Add(new Zemja("South Africa", 0));
            zemji.Add(new Zemja("Afghanistan", 0));
            zemji.Add(new Zemja("China", 0));
            zemji.Add(new Zemja("India", 0));
            zemji.Add(new Zemja("Irkutsk", 0));
            zemji.Add(new Zemja("Japan", 0));
            zemji.Add(new Zemja("Kamchatka", 0));
            zemji.Add(new Zemja("Middle East", 0));
            zemji.Add(new Zemja("Mongolia", 0));
            zemji.Add(new Zemja("Siam", 0));
            zemji.Add(new Zemja("Siberia", 0));
            zemji.Add(new Zemja("Ural", 0));
            zemji.Add(new Zemja("Yakutsk", 0));
            zemji.Add(new Zemja("Eastern Australia", 0));
            zemji.Add(new Zemja("Indonesia", 0));
            zemji.Add(new Zemja("New Guinea", 0));
            zemji.Add(new Zemja("Western Australia", 0));

            Zemja westernAustralia = getZemja("Western Australia");
            Zemja newGuinea = getZemja("New Guinea");
            Zemja indonesia = getZemja("Indonesia");
            Zemja easternAustralia = getZemja("Eastern Australia");
            Zemja siam = getZemja("Siam");
            Zemja yakutsk = getZemja("Yakutsk");
            Zemja ural = getZemja("Ural");
            Zemja siberia = getZemja("Siberia");
            Zemja mongolia = getZemja("Mongolia");
            Zemja middleEast = getZemja("Middle East");
            Zemja kamchatka = getZemja("Kamchatka");
            Zemja japan = getZemja("Japan");
            Zemja irkutsk = getZemja("Irkutsk");
            Zemja india = getZemja("India");
            Zemja china = getZemja("China");
            Zemja afghanistan = getZemja("Afghanistan");
            Zemja southAfrica = getZemja("South Africa");
            Zemja northAfrica = getZemja("North Africa");
            Zemja madagascar = getZemja("Madagascar");
            Zemja egypt = getZemja("Egypt");
            Zemja eastAfrica = getZemja("East Africa");
            Zemja congo = getZemja("Congo");
            Zemja westernEurope = getZemja("Western Europe");
            Zemja ukraine = getZemja("Ukraine");
            Zemja southernEurope = getZemja("Southern Europe");
            Zemja scandinavia = getZemja("Scandinavia");
            Zemja northernEurope = getZemja("Northern Europe");
            Zemja iceland = getZemja("Iceland");
            Zemja greatBritain = getZemja("Great Britain");
            Zemja greenland = getZemja("Greenland");
            Zemja alaska = getZemja("Alaska");
            Zemja alberta = getZemja("Alberta");
            Zemja centralAmerica = getZemja("Central America");
            Zemja easternUStates = getZemja("Eastern United States");
            Zemja northWestTerritory = getZemja("Northwest Territory");
            Zemja ontario = getZemja("Ontario");
            Zemja quebec = getZemja("Quebec");
            Zemja westernUStates = getZemja("Western United States");
            Zemja argentina = getZemja("Argentina");
            Zemja brazil = getZemja("Brazil");
            Zemja peru = getZemja("Peru");
            Zemja venezuela = getZemja("Venezuela");

            kontinenti.addZemjaVoEvropa(greatBritain);
            kontinenti.addZemjaVoEvropa(iceland);
            kontinenti.addZemjaVoEvropa(northernEurope);
            kontinenti.addZemjaVoEvropa(southernEurope);
            kontinenti.addZemjaVoEvropa(westernEurope);
            kontinenti.addZemjaVoEvropa(scandinavia);
            kontinenti.addZemjaVoEvropa(ukraine);

            kontinenti.addZemjaVoAfrika(congo);
            kontinenti.addZemjaVoAfrika(eastAfrica);
            kontinenti.addZemjaVoAfrika(egypt);
            kontinenti.addZemjaVoAfrika(madagascar);
            kontinenti.addZemjaVoAfrika(northAfrica);
            kontinenti.addZemjaVoAfrika(southAfrica);

            kontinenti.addZemjaVoAvstralija(easternAustralia);
            kontinenti.addZemjaVoAvstralija(indonesia);
            kontinenti.addZemjaVoAvstralija(westernAustralia);
            kontinenti.addZemjaVoAvstralija(newGuinea);

            kontinenti.addZemjaVoJuznaAmerika(argentina);
            kontinenti.addZemjaVoJuznaAmerika(brazil);
            kontinenti.addZemjaVoJuznaAmerika(peru);
            kontinenti.addZemjaVoJuznaAmerika(venezuela);

            kontinenti.addZemjaVoSevernaAmerika(alaska);
            kontinenti.addZemjaVoSevernaAmerika(alberta);
            kontinenti.addZemjaVoSevernaAmerika(centralAmerica);
            kontinenti.addZemjaVoSevernaAmerika(easternUStates);
            kontinenti.addZemjaVoSevernaAmerika(westernUStates);
            kontinenti.addZemjaVoSevernaAmerika(greenland);
            kontinenti.addZemjaVoSevernaAmerika(northWestTerritory);
            kontinenti.addZemjaVoSevernaAmerika(ontario);
            kontinenti.addZemjaVoSevernaAmerika(quebec);

            kontinenti.addZemjaVoAzija(afghanistan);
            kontinenti.addZemjaVoAzija(china);
            kontinenti.addZemjaVoAzija(india);
            kontinenti.addZemjaVoAzija(irkutsk);
            kontinenti.addZemjaVoAzija(yakutsk);
            kontinenti.addZemjaVoAzija(kamchatka);
            kontinenti.addZemjaVoAzija(japan);
            kontinenti.addZemjaVoAzija(middleEast);
            kontinenti.addZemjaVoAzija(mongolia);
            kontinenti.addZemjaVoAzija(siam);
            kontinenti.addZemjaVoAzija(siberia);
            kontinenti.addZemjaVoAzija(ural);

            westernAustralia.labela = lblWesternAustralia;
            lblWesternAustralia.Tag = westernAustralia;
            westernAustralia.addSosed(newGuinea);
            westernAustralia.addSosed(indonesia);
            westernAustralia.addSosed(easternAustralia);

            
            newGuinea.labela = lblNewGuinea;
            lblNewGuinea.Tag = newGuinea;
            newGuinea.addSosed(westernAustralia);
            newGuinea.addSosed(indonesia);
            newGuinea.addSosed(easternAustralia);

            
            indonesia.labela = lblIndonesia;
            lblIndonesia.Tag = indonesia;
            indonesia.addSosed(westernAustralia);
            indonesia.addSosed(newGuinea);
            indonesia.addSosed(siam);


            
            easternAustralia.labela = lblEasternAustralia;
            lblEasternAustralia.Tag = easternAustralia;
            easternAustralia.addSosed(westernAustralia);
            easternAustralia.addSosed(newGuinea);

            yakutsk.labela = lblYakutsk;
            lblYakutsk.Tag = yakutsk;
            yakutsk.addSosed(kamchatka);
            yakutsk.addSosed(irkutsk);
            yakutsk.addSosed(siberia);

            ural.labela = lblUral;
            lblUral.Tag = ural;
            ural.addSosed(afghanistan);
            ural.addSosed(siberia);
            ural.addSosed(ukraine);
            ural.addSosed(china);

            siberia.labela = lblSiberia;
            lblSiberia.Tag = siberia;
            siberia.addSosed(china);
            siberia.addSosed(ural);
            siberia.addSosed(irkutsk);
            siberia.addSosed(yakutsk);
            siberia.addSosed(mongolia);

            siam.labela = lblSiam;
            lblSiam.Tag = siam;
            siam.addSosed(indonesia);
            siam.addSosed(china);
            siam.addSosed(india);

            mongolia.labela = lblMongolia;
            lblMongolia.Tag = mongolia;
            mongolia.addSosed(kamchatka);
            mongolia.addSosed(irkutsk);
            mongolia.addSosed(japan);
            mongolia.addSosed(china);
            mongolia.addSosed(siberia);

            middleEast.labela = lblMiddleEast;
            lblMiddleEast.Tag = middleEast;
            middleEast.addSosed(eastAfrica);
            middleEast.addSosed(egypt);
            middleEast.addSosed(southernEurope);
            middleEast.addSosed(ukraine);
            middleEast.addSosed(afghanistan);
            middleEast.addSosed(india);

            kamchatka.labela = lblKamchatka;
            lblKamchatka.Tag = kamchatka;
            kamchatka.addSosed(japan);
            kamchatka.addSosed(mongolia);
            kamchatka.addSosed(irkutsk);
            kamchatka.addSosed(yakutsk);
            kamchatka.addSosed(alaska);

            japan.labela = lblJapan;
            lblJapan.Tag = japan;
            japan.addSosed(mongolia);
            japan.addSosed(kamchatka);

            irkutsk.labela = lblIrkutsk;
            lblIrkutsk.Tag = irkutsk;
            irkutsk.addSosed(yakutsk);
            irkutsk.addSosed(kamchatka);
            irkutsk.addSosed(siberia);
            irkutsk.addSosed(mongolia);

            india.labela = lblIndia;
            lblIndia.Tag = india;
            india.addSosed(siam);
            india.addSosed(china);
            india.addSosed(middleEast);
            india.addSosed(afghanistan);

            china.labela = lblChina;
            lblChina.Tag = china;
            china.addSosed(india);
            china.addSosed(mongolia);
            china.addSosed(siam);
            china.addSosed(afghanistan);
            china.addSosed(siberia);
            china.addSosed(ural);

            afghanistan.labela = lblAfghanistan;
            lblAfghanistan.Tag = afghanistan;
            afghanistan.addSosed(china);
            afghanistan.addSosed(india);
            afghanistan.addSosed(middleEast);
            afghanistan.addSosed(ural);
            afghanistan.addSosed(ukraine);

            southAfrica.labela = lblSouthAfrica;
            lblSouthAfrica.Tag = southAfrica;
            southAfrica.addSosed(eastAfrica);
            southAfrica.addSosed(madagascar);
            southAfrica.addSosed(congo);

            northAfrica.labela = lblNorthAfrica;
            lblNorthAfrica.Tag = northAfrica;
            northAfrica.addSosed(egypt);
            northAfrica.addSosed(congo);
            northAfrica.addSosed(eastAfrica);
            northAfrica.addSosed(westernEurope);
            northAfrica.addSosed(brazil);
            northAfrica.addSosed(southernEurope);

            madagascar.labela = lblMadagascar;
            lblMadagascar.Tag = madagascar;
            madagascar.addSosed(southAfrica);
            madagascar.addSosed(eastAfrica);

            egypt.labela = lblEgypt;
            lblEgypt.Tag = egypt;
            egypt.addSosed(northAfrica);
            egypt.addSosed(eastAfrica);
            egypt.addSosed(middleEast);
            egypt.addSosed(southernEurope);

            eastAfrica.labela = lblEastAfrica;
            lblEastAfrica.Tag = eastAfrica;
            eastAfrica.addSosed(egypt);
            eastAfrica.addSosed(southAfrica);
            eastAfrica.addSosed(madagascar);
            eastAfrica.addSosed(northAfrica);
            eastAfrica.addSosed(congo);
            eastAfrica.addSosed(middleEast);

            congo.labela = lblCongo;
            lblCongo.Tag = congo;
            congo.addSosed(eastAfrica);
            congo.addSosed(northAfrica);
            congo.addSosed(southAfrica);

            westernEurope.labela = lblWesternEurope;
            lblWesternEurope.Tag = westernEurope;
            westernEurope.addSosed(northAfrica);
            westernEurope.addSosed(southernEurope);
            westernEurope.addSosed(northernEurope);
            westernEurope.addSosed(greatBritain);

            ukraine.labela = lblUkraine;
            lblUkraine.Tag = ukraine;
            ukraine.addSosed(ural);
            ukraine.addSosed(afghanistan);
            ukraine.addSosed(middleEast);
            ukraine.addSosed(northernEurope);
            ukraine.addSosed(southernEurope);
            ukraine.addSosed(scandinavia);

            southernEurope.labela = lblSouthernEurope;
            lblSouthernEurope.Tag = southernEurope;
            southernEurope.addSosed(ukraine);
            southernEurope.addSosed(northernEurope);
            southernEurope.addSosed(westernEurope);
            southernEurope.addSosed(middleEast);
            southernEurope.addSosed(northAfrica);
            southernEurope.addSosed(egypt);

            scandinavia.labela = lblScandinavia;
            lblScandinavia.Tag = scandinavia;
            scandinavia.addSosed(ukraine);
            scandinavia.addSosed(northernEurope);
            scandinavia.addSosed(iceland);
            scandinavia.addSosed(greatBritain);

            northernEurope.labela = lblNorthernEurope;
            lblNorthernEurope.Tag = northernEurope;
            northernEurope.addSosed(ukraine);
            northernEurope.addSosed(scandinavia);
            northernEurope.addSosed(southernEurope);
            northernEurope.addSosed(westernEurope);
            northernEurope.addSosed(greatBritain);

            iceland.labela = lblIceland;
            lblIceland.Tag = iceland;
            iceland.addSosed(scandinavia);
            iceland.addSosed(greatBritain);
            iceland.addSosed(greenland);

            greatBritain.labela = lblGreatBritain;
            lblGreatBritain.Tag = greatBritain;
            greatBritain.addSosed(iceland);
            greatBritain.addSosed(northernEurope);
            greatBritain.addSosed(scandinavia);
            greatBritain.addSosed(westernEurope);

            greenland.labela = lblGreenland;
            lblGreenland.Tag = greenland;
            greenland.addSosed(iceland);
            greenland.addSosed(northWestTerritory);
            greenland.addSosed(quebec);
            greenland.addSosed(ontario);

            alaska.labela = lblAlaska;
            lblAlaska.Tag = alaska;
            alaska.addSosed(kamchatka);
            alaska.addSosed(northWestTerritory);
            alaska.addSosed(alberta);

            alberta.labela = lblAlberta;
            lblAlberta.Tag = alberta;
            alberta.addSosed(alaska);
            alberta.addSosed(northWestTerritory);
            alberta.addSosed(ontario);
            alberta.addSosed(westernUStates);

            centralAmerica.labela = lblCentralAmerica;
            lblCentralAmerica.Tag = centralAmerica;
            centralAmerica.addSosed(westernUStates);
            centralAmerica.addSosed(easternUStates);
            centralAmerica.addSosed(venezuela);

            easternUStates.labela = lblEasternUStates;
            lblEasternUStates.Tag = easternUStates;
            easternUStates.addSosed(centralAmerica);
            easternUStates.addSosed(westernUStates);
            easternUStates.addSosed(ontario);
            easternUStates.addSosed(quebec);

            northWestTerritory.labela = lblNorthWestTerritory;
            lblNorthWestTerritory.Tag = northWestTerritory;
            northWestTerritory.addSosed(greenland);
            northWestTerritory.addSosed(alaska);
            northWestTerritory.addSosed(alberta);
            northWestTerritory.addSosed(ontario);

            ontario.labela = lblOntario;
            lblOntario.Tag = ontario;
            ontario.addSosed(northWestTerritory);
            ontario.addSosed(easternUStates);
            ontario.addSosed(greenland);
            ontario.addSosed(quebec);
            ontario.addSosed(alberta);
            ontario.addSosed(westernUStates);

            quebec.labela = lblQuebec;
            lblQuebec.Tag = quebec;
            quebec.addSosed(ontario);
            quebec.addSosed(greenland);
            quebec.addSosed(easternUStates);

            westernUStates.labela = lblWesternUStates;
            lblWesternUStates.Tag = westernUStates;
            westernUStates.addSosed(alberta);
            westernUStates.addSosed(ontario);
            westernUStates.addSosed(easternUStates);
            westernUStates.addSosed(centralAmerica);

            argentina.labela = lblArgentina;
            lblArgentina.Tag = argentina;
            argentina.addSosed(peru);
            argentina.addSosed(brazil);

            brazil.labela = lblBrazil;
            lblBrazil.Tag = brazil;
            brazil.addSosed(argentina);
            brazil.addSosed(peru);
            brazil.addSosed(venezuela);
            brazil.addSosed(northAfrica);

            peru.labela = lblPeru;
            lblPeru.Tag = peru;
            peru.addSosed(brazil);
            peru.addSosed(argentina);
            peru.addSosed(venezuela);

            venezuela.labela = lblVenezuela;
            lblVenezuela.Tag = venezuela;
            venezuela.addSosed(peru);
            venezuela.addSosed(brazil);
            venezuela.addSosed(centralAmerica);


        }

        public Zemja getZemja(string ime)
        {
            foreach(Zemja zemja in zemji)
            {
                if(zemja.Ime == ime)
                {
                    return zemja;
                }
            }
            return null;
        }
        
        private void lblGreenland_Click(object sender, EventArgs e)
        {
            Zemja zem = lblGreenland.Tag as Zemja;
            if (zem != null)
            lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
            lblKlikAzurirajLb(zem);
        }

        private void lblAlaska_Click(object sender, EventArgs e)
        {
            Zemja zem = lblAlaska.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblNorthWestTerritory_Click(object sender, EventArgs e)
        {
            Zemja zem = lblNorthWestTerritory.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblAlberta_Click(object sender, EventArgs e)
        {
            Zemja zem = lblAlberta.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblOntario_Click(object sender, EventArgs e)
        {
            Zemja zem = lblOntario.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblQuebec_Click(object sender, EventArgs e)
        {
            Zemja zem = lblQuebec.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblWesternUStates_Click(object sender, EventArgs e)
        {
            Zemja zem = lblWesternUStates.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblEasternUStates_Click(object sender, EventArgs e)
        {
            Zemja zem = lblEasternUStates.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblCentralAmerica_Click(object sender, EventArgs e)
        {
            Zemja zem = lblCentralAmerica.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblVenezuela_Click(object sender, EventArgs e)
        {
            Zemja zem = lblVenezuela.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblPeru_Click(object sender, EventArgs e)
        {
            Zemja zem = lblPeru.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblBrazil_Click(object sender, EventArgs e)
        {
            Zemja zem = lblBrazil.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblArgentina_Click(object sender, EventArgs e)
        {
            Zemja zem = lblArgentina.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblMadagascar_Click(object sender, EventArgs e)
        {
            Zemja zem = lblMadagascar.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblSouthAfrica_Click(object sender, EventArgs e)
        {
            Zemja zem = lblSouthAfrica.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblCongo_Click(object sender, EventArgs e)
        {
            Zemja zem = lblCongo.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblEastAfrica_Click(object sender, EventArgs e)
        {
            Zemja zem = lblEastAfrica.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblNorthAfrica_Click(object sender, EventArgs e)
        {
            Zemja zem = lblNorthAfrica.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblEgypt_Click(object sender, EventArgs e)
        {
            Zemja zem = lblEgypt.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblEasternAustralia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblEasternAustralia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblWesternAustralia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblWesternAustralia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblNewGuinea_Click(object sender, EventArgs e)
        {
            Zemja zem = lblNewGuinea.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblIndonesia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblIndonesia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblIceland_Click(object sender, EventArgs e)
        {
            Zemja zem = lblIceland.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblGreatBritain_Click(object sender, EventArgs e)
        {
            Zemja zem = lblGreatBritain.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblScandinavia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblScandinavia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblNorthernEurope_Click(object sender, EventArgs e)
        {
            Zemja zem = lblNorthernEurope.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblWesternEurope_Click(object sender, EventArgs e)
        {
            Zemja zem = lblWesternEurope.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblSouthernEurope_Click(object sender, EventArgs e)
        {
            Zemja zem = lblSouthernEurope.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblUkraine_Click(object sender, EventArgs e)
        {
            Zemja zem = lblUkraine.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }
        
        private void lblMiddleEast_Click(object sender, EventArgs e)
        {
            Zemja zem = lblMiddleEast.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblAfghanistan_Click(object sender, EventArgs e)
        {
            Zemja zem = lblAfghanistan.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblUral_Click(object sender, EventArgs e)
        {
            Zemja zem = lblUral.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblSiberia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblSiberia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblIndia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblIndia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblSiam_Click(object sender, EventArgs e)
        {
            Zemja zem = lblSiam.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblChina_Click(object sender, EventArgs e)
        {
            Zemja zem = lblChina.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblJapan_Click(object sender, EventArgs e)
        {
            Zemja zem = lblJapan.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblMongolia_Click(object sender, EventArgs e)
        {
            Zemja zem = lblMongolia.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblIrkutsk_Click(object sender, EventArgs e)
        {
            Zemja zem = lblIrkutsk.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblYakutsk_Click(object sender, EventArgs e)
        {
            Zemja zem = lblYakutsk.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblKamchatka_Click(object sender, EventArgs e)
        {
            Zemja zem = lblKamchatka.Tag as Zemja;
            if (zem != null)
                lblZemjaIme.Text = zem.ToString();
            lblZemjaClick(zem);
            lblInfoVojnici.Text = zem.Vojnici.ToString();
            lblKlikAzurirajLb(zem);
            foreach (Zemja z in zemji)
            {
                if (z.isSelected)
                {
                    z.isSelected = false;
                }
            }
            zem.isSelected = true;
        }

        private void lblZemjaClick(Zemja ze)
        {
            string str = "";
            string str2 = "";
            int i = 0;
            foreach(Zemja z in ze.Sosedi)
            {
                if (i < 3)
                {
                    str += z.ToString();
                    str += ",";
                } else
                {
                    str2 += z.ToString();
                    str2 += ",";
                }
                i++;
            }
            lblInfoSosedni.Text = str;
            lblInfoSosedi2.Text = str2;
            if (ze.ZemjoPosednik != null)
            {
                label10.Text = ze.ZemjoPosednik.Ime;
            } else
            {
                label10.Text = "Нема";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Направено од Марио Космач","About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Дали сте сигурни дека сакате да излезете", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private bool imaZemjoPosednik()
        {
            foreach(Zemja z in zemji)
            {
                if(z.ZemjoPosednik == null)
                {
                    return true;
                } 
            }

            return false;
        }

        private void azurirajInfoIgraci() 
        {
            if(players.Count > 0)
            {
                int br = players.Count;
                for(int i = 0; i < br; i++)
                {
                    if(i == 0)
                    {
                        lblIme1.Text = players[i].Ime;
                        lblIgracText1.BackColor = players[i].Boja;
                        lblVojnici1.Text = players[i].Vojnici.ToString();
                        lblTeritorii1.Text = players[i].BrojTeritorii.ToString();
                    }
                    if(i == 1)
                    {
                        lblIme2.Text = players[i].Ime;
                        lblIgracText2.BackColor = players[i].Boja;
                        lblVojnici2.Text = players[i].Vojnici.ToString();
                        lblTeritorii2.Text = players[i].BrojTeritorii.ToString();
                    } if (i == 2)
                    {
                        lblIme3.Text = players[i].Ime;
                        lblIgracText3.BackColor = players[i].Boja;
                        lblVojnici3.Text = players[i].Vojnici.ToString();
                        lblTeritorii3.Text = players[i].BrojTeritorii.ToString();
                    } if (i == 3)
                    {
                        lblIme4.Text = players[i].Ime;
                        lblIgracText4.BackColor = players[i].Boja;
                        lblVojnici4.Text = players[i].Vojnici.ToString();
                        lblTeritorii4.Text = players[i].BrojTeritorii.ToString();

                    } if(i == 4)
                    {
                        lblIme5.Text = players[i].Ime;
                        lblIgracText5.BackColor = players[i].Boja;
                        lblVojnici5.Text = players[i].Vojnici.ToString();
                        lblTeritorii5.Text = players[i].BrojTeritorii.ToString();
                    } if (i == 5)
                    {
                        lblIme6.Text = players[i].Ime;
                        lblIgracText6.BackColor = players[i].Boja;
                        lblVojnici6.Text = players[i].Vojnici.ToString();
                        lblTeritorii6.Text = players[i].BrojTeritorii.ToString();
                    }
                }
            }
        }

        private void azurirajSve()
        {
            azurirajInfoIgraci();
            foreach(Zemja z in zemji)
            {
                z.labela.Text = z.Vojnici.ToString();
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame ca = new NewGame();
            if (ca.ShowDialog() == DialogResult.OK)
            {
                Zemja[] zemjite = zemji.ToArray();
                Igrac[] igraci = ca.igracite.ToArray();
                int index, index2;
                index2 = 0;
                int startVojnici = 40 - ((NewGame.count - 2) * 5);

                foreach (Igrac ig in ca.igracite)
                {
                    ig.Vojnici = startVojnici;
                    players.Add(ig);
                }

                for (int i = 0; i < NewGame.count; i++)
                {
                    if (i == 0)
                    {
                        lblIgracText1.Visible = true;
                        lblIme1.Visible = true;
                        lblTeritorii1.Visible = true;
                        lblVojnici1.Visible = true;
                    }
                    else if (i == 1)
                    {
                        lblIgracText2.Visible = true;
                        lblIme2.Visible = true;
                        lblTeritorii2.Visible = true;
                        lblVojnici2.Visible = true;
                    }
                    else if (i == 2)
                    {
                        lblIgracText3.Visible = true;
                        lblIme3.Visible = true;
                        lblTeritorii3.Visible = true;
                        lblVojnici3.Visible = true;
                    }
                    else if (i == 3)
                    {
                        lblIgracText4.Visible = true;
                        lblIme4.Visible = true;
                        lblTeritorii4.Visible = true;
                        lblVojnici4.Visible = true;
                    }
                    else if (i == 4)
                    {
                        lblIgracText5.Visible = true;
                        lblIme5.Visible = true;
                        lblTeritorii5.Visible = true;
                        lblVojnici5.Visible = true;
                    }
                    else if (i == 5)
                    {
                        lblIgracText6.Visible = true;
                        lblIme6.Visible = true;
                        lblTeritorii6.Visible = true;
                        lblVojnici6.Visible = true;
                    }
                }

                while (imaZemjoPosednik())
                {
                    index = rand.Next(brojNaZemji);

                    if (zemjite[index].ZemjoPosednik == null)
                    {
                        zemjite[index].ZemjoPosednik = igraci[index2];
                        igraci[index2].addKontroliraniTeritorii(zemjite[index]);
                        zemjite[index].Vojnici = 1;
                        zemjite[index].labela.BackColor = igraci[index2].Boja;
                        zemjite[index].labela.Text = zemjite[index].Vojnici.ToString();
                        igraci[index2].BrojTeritorii++;
                        if (index2 == (NewGame.count - 1))
                        {
                            index2 = 0;
                        }
                        else
                        {
                            index2++;
                        }
                    }

                }//dodeli teritorii
                azurirajInfoIgraci();
                for (int i = 0; i < NewGame.count; i++)
                {
                    for (int j = 0; j < startVojnici - igraci[i].BrojTeritorii; j++)
                    {
                        int n = rand.Next(igraci[i].KontroliraniTeritorii.Count);
                        igraci[i].KontroliraniTeritorii[n].Vojnici++;
                        igraci[i].KontroliraniTeritorii[n].labela.Text = igraci[i].KontroliraniTeritorii[n].Vojnici.ToString();
                    }
                }// randomVojniciRaspored na site teritorii
                azurirajInfoIgraci();
                pocniIgra();

            }
        }

        private bool daliImePobednik()
        {
            foreach(Igrac i in players)
            {
                if(i.daliPobediv())
                {
                    return true;
                }
            }
            return false;
        }// Treba da se vmetne!!

        private int brojVojniciOdKontineti(Igrac igrac)
        {
            int n = 0;
            int afrika = 0, seamerika = 0, juamerika = 0, evropa = 0, azija = 0, avstral = 0;
            foreach(Zemja z in igrac.KontroliraniTeritorii)
            {
                foreach(Zemja afr in kontinenti.Afrika)
                { if (afrika == 6) break;
                        if(z.Ime.Equals(afr.Ime))
                        {
                            afrika++;
                            if(afrika == 6)
                            {
                            n += 3;
                            }
                        }
                }

                foreach (Zemja evr in kontinenti.Evropa)
                {
                    if (evropa == 7) break;
                    if (z.Ime.Equals(evr.Ime))
                    {
                        evropa++;
                        if (evropa == 7)
                        {
                            n += 5;
                        }
                    }
                }

                foreach (Zemja samer in kontinenti.SevernaAmerika)
                {
                    if (seamerika == 9) break;
                    if (z.Ime.Equals(samer.Ime))
                    {
                        seamerika++;
                        if (seamerika == 9)
                        {
                            n += 5;
                        }
                    }
                }

                foreach (Zemja jamer in kontinenti.JuznaAmerika)
                {
                    if (juamerika == 4) break;
                    if (z.Ime.Equals(jamer.Ime))
                    {
                        juamerika++;
                        if (juamerika == 4)
                        {
                            n += 2;
                        }
                    }
                }

                foreach (Zemja avs in kontinenti.Avstralija)
                {
                    if (avstral == 4) break;
                    if (z.Ime.Equals(avs.Ime))
                    {
                        avstral++;
                        if (avstral == 4)
                        {
                            n += 2;
                        }
                    }
                }

                foreach (Zemja asia in kontinenti.Azija)
                {
                    if (azija == 12) break;
                    if (z.Ime.Equals(asia.Ime))
                    {
                        azija++;
                        if (azija == 12)
                        {
                            n += 7;
                        }
                    }
                }
            }
            return n;
            
        }//Kolku vojnci dobiva od kontinent

        private void lblKlikAzurirajLb(Zemja ze)
        {
            lbSosedniTeritoriiIgrac.Items.Clear();
            if((ze.ZemjoPosednik != null) && (ze.ZemjoPosednik.isTurn))
            {
                foreach (Zemja zemji in ze.Sosedi) {
                    lbSosedniTeritoriiIgrac.Items.Add(zemji);
                }
            } 
        }

        private void pocniIgra()
        {
                    players[0].isTurn = true;
                    players[0].pomestiEdnas = true;
                    grbIgrac.Text = "На ред е играч:" + players[0].Ime;
                    float brojVojniciDodadi = (players[0].BrojTeritorii / 2);
                    brojVojniciDodadi += brojVojniciOdKontineti(players[0]);
                    if(brojVojniciDodadi < 3)
                    {
                        brojVojniciDodadi = 3;
                    }
                    players[0].brDodadiVojnik = (int)brojVojniciDodadi;
                    players[0].Vojnici += players[0].brDodadiVojnik;
                    lblOstanatiVojnici.Text = players[0].brDodadiVojnik.ToString();
                    azurirajInfoIgraci();
        }

        private void prodolziIgra(Igrac ig)
        {
            ig.isTurn = true;
            ig.pomestiEdnas = true;
            grbIgrac.Text = "На ред е играч:" + ig.Ime;
            float brojVojniciDodadi = (ig.BrojTeritorii / 2);
            brojVojniciDodadi += brojVojniciOdKontineti(ig);
            if (brojVojniciDodadi < 3)
            {
                brojVojniciDodadi = 3;
            }
            ig.brDodadiVojnik = (int)brojVojniciDodadi;
            ig.Vojnici += ig.brDodadiVojnik;
            lblOstanatiVojnici.Text = ig.brDodadiVojnik.ToString();
            azurirajInfoIgraci();
        }

        private void dodadiVojnikDClick(object sender, MouseEventArgs e)
        {
            Label lab = sender as Label;
            Zemja zemja = lab.Tag as Zemja;
            if((zemja != null) && (zemja.ZemjoPosednik != null))
            {
                if (zemja.ZemjoPosednik.brDodadiVojnik > 0 && zemja.ZemjoPosednik.isTurn)
                {
                    zemja.Vojnici++;
                    zemja.labela.Text = zemja.Vojnici.ToString();
                    zemja.ZemjoPosednik.brDodadiVojnik--;
                    lblOstanatiVojnici.Text = zemja.ZemjoPosednik.brDodadiVojnik.ToString();
                }
            }
        }

        private Zemja civRedE()
        {
            for(int i = 0; i < brojNaZemji; i++)
            {
                if(zemji[i].ZemjoPosednik.isTurn && zemji[i].isSelected)
                {
                    return zemji[i];
                }
            }
            return null;
        }

        private void btnGotov_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (players.Count > 1)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].isTurn)
                    {
                        n = i;
                    }
                }

                if (players[n].brDodadiVojnik == 0)
                {
                    players[n].isTurn = false;
                    if ((n + 1) == players.Count)
                    {
                        n = 0;
                    }
                    else
                    {
                        n++;
                    }
                    prodolziIgra(players[n]);
                    lbSosedniTeritoriiIgrac.Items.Clear();
                }
            }
        }

        private void btnNapad_Click(object sender, EventArgs e)
        {
            Zemja selzemja = lbSosedniTeritoriiIgrac.SelectedItem as Zemja;
            if (selzemja != null)
            {
                Zemja zemjaNared = civRedE();
                Napad napad = new Napad();
                napad.pocni(zemjaNared, selzemja);
                napad.ShowDialog();
                if (napad.izgubi != null)
                {
                    dajIzguben = napad.izgubi;
                }
                azurirajSve();
                if (napad.izgubi != null)
                {
                    foreach(Igrac i in players)
                    {
                        if(i.Ime == dajIzguben.Ime)
                        {
                            players.Remove(i);
                            NewGame.count--;
                        }
                    }
                }
                if (zemjaNared.ZemjoPosednik.daliPobediv())
                {
                    string str = "Pobednik e igracot " + zemjaNared.ZemjoPosednik.Ime;
                    MessageBox.Show(str, "Victory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }

        }

        private void btnPomestVojnici_Click(object sender, EventArgs e)
        {
            Zemja naRed = civRedE();
            if(naRed.ZemjoPosednik.pomestiEdnas)
            {
                PomestiVojnici pom = new PomestiVojnici();
                Zemja selzemja = lbSosedniTeritoriiIgrac.SelectedItem as Zemja;
                pom.pocni(naRed,selzemja);
                pom.ShowDialog();
                if (pom.DialogResult == DialogResult.OK)
                {
                    naRed.ZemjoPosednik.pomestiEdnas = false;
                }
                azurirajSve();
            } else
            {
                MessageBox.Show("Само еднаш на ред може да се поместуваат војници");
            }
        }

        private void lbSosedniTeritoriiIgrac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zemja selzemja = lbSosedniTeritoriiIgrac.SelectedItem as Zemja;
            if (selzemja != null)
            {
                btnNapad.Enabled = !selzemja.ZemjoPosednik.isTurn;
                btnPomestVojnici.Enabled = selzemja.ZemjoPosednik.isTurn;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules();
            rule.ShowDialog();
        }
    }
}
