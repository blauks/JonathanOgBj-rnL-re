using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Læringsapplikasjon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Globale variabler:
        int hvilketSpill;
        int Poeng = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pStartmeny.Dock = DockStyle.Fill;
            pSpillmeny.Dock = DockStyle.Fill;
            pFigurspill.Dock = DockStyle.Fill;
            pRegnespill.Dock = DockStyle.Fill;
            pDyrespill.Dock = DockStyle.Fill;
            pSpillmeny.Visible = false;
            pFigurspill.Visible = false;
            pRegnespill.Visible = false;
            pDyrespill.Visible = false;
        }





        private void StartmenyHover(object sender, EventArgs e) //når du holder musepekeren over en knapp i startmenyen endrer bakgrunnen seg
        {                                                        //til det som passer til spillet
            Button bt = sender as Button;

            if(bt == btStartF)
            {
                pbStartmeny.Image = Læringsapplikasjon.Properties.Resources.figurspill;
            }
            else if(bt == btStartT)
            {
                pbStartmeny.Image = Læringsapplikasjon.Properties.Resources.tallspill;
            }
            else if(bt == btStartD)
            {
                pbStartmeny.Image = Læringsapplikasjon.Properties.Resources.dyrspill;
            }
            
        }

        private void StartmenyClick(object sender, MouseEventArgs e) //sjekker hvilken knapp i startmenyen du trykker på og endrer
        {                                                               //inten hvilketspill til det spillet som passer
            Button bt = sender as Button;                                //åpner også startmenyen
            if (bt == btStartF)
            {
                hvilketSpill = 0;
            }
            else if (bt == btStartT)
            {
                hvilketSpill = 1;
            }
            else if (bt == btStartD)
            {
                hvilketSpill = 2;
            }

            pSpillmeny.Visible = true;
            pSpillmeny.Dock = DockStyle.Fill;
            HvilketSpillISpillMeny();
        }

        private void TilbakeKnapp(object sender, EventArgs e) //sjekker hvilken tilbakeknapp du trykker på og sender deg til det riktige panelet
        {
            Button bt = sender as Button;
            if(pSpillmeny.Visible == true)
            {
                pSpillmeny.Visible = false;
            }
            else if(bt == btFigurspillTi)
            {
                Poeng = 0;
                FigurspillTimer.Stop();
                GjemmeSpillPanelene();
            }
        }

        private void GjemmeSpillPanelene() //Gjemmer alle spillpanelene 
        {
            pFigurspill.Visible = false;
            pDyrespill.Visible = false;
            pRegnespill.Visible = false;
            pSpillmeny.Visible = true;
        }

        private void HvilketSpillISpillMeny() //sjekker hva inten hvilketSpill er også endrer bakgrunnen og lNavnSpill til det som tilhører
        {                                      //spillet
            switch (hvilketSpill)
            {
                case 0: lNavnSpill.Text = "Figurspill"; pbSpillmeny.Image = Læringsapplikasjon.Properties.Resources.figurspill; break;
                case 1: lNavnSpill.Text = "Tallspill"; pbSpillmeny.Image = Læringsapplikasjon.Properties.Resources.tallspill; break;
                case 2: lNavnSpill.Text = "Dyrespill"; pbSpillmeny.Image = Læringsapplikasjon.Properties.Resources.dyrspill; break;
            }

        }

        #region FigurSpill

        int RandomFigurInt;

        private void FigurspillKnapper(object sender, EventArgs e) //Sjekker om knappen man trykker på er riktig eller ikke, 
                                                                    //hvis den er riktig vil man få et poeng og hvis det er feil blir man sendt
        {                                                           //tilbake til spillmenyen
            Button b = sender as Button;
            Random r = new Random();
         
            if(b == btFigurspillTr && RandomFigurInt == 0 ||
                b == btFigurspillFi && RandomFigurInt == 1 ||
                b == btFigurspillSi && RandomFigurInt == 2 ||
                b == btFigurspillSt && RandomFigurInt == 3 ||
                b == btFigurspillFe && RandomFigurInt == 4)
            {
                b.BackColor = Color.Green;
                Poeng++;
                lFigurspillFeilEllerRiktig.Text = "Riktig Svar!";
                lFigurspillPoeng.Text = Convert.ToString(Poeng);
                RandomFigurInt = r.Next(5);
                FigurspillTimer.Stop();
                HvilkenFigurSkalVises(RandomFigurInt);
            }
            else
            {
                Poeng = 0;
                GjemmeSpillPanelene();
            }

        }

        private void FigurTimer_Tick(object sender, EventArgs e) //flytter picturenboxen med figuren i nedover
        {
            int YVerdi = pbFigurspill.Location.Y;
            YVerdi += 45;
            pbFigurspill.Location = new Point(372, YVerdi);
            GjørAlleFigurKnapperRøde();
            if (pbFigurspill.Bounds.IntersectsWith(panel1.Bounds))
            {
                Poeng = 0;
                GjemmeSpillPanelene();
            }
        }

        private void GjørAlleFigurKnapperRøde() //Gjør alle de forskjellige figurknappene røde og tar bort tekseten i lFigurspillFeilEllerRiktig
        {
            btFigurspillFe.BackColor = Color.Red;
            btFigurspillFi.BackColor = Color.Red;
            btFigurspillSi.BackColor = Color.Red;
            btFigurspillSt.BackColor = Color.Red;
            btFigurspillTr.BackColor = Color.Red;
            lFigurspillFeilEllerRiktig.Text = "";
        }

        private void HvilkenFigurSkalVises(int rnd) //lager en random int verdi for å vise et av de 5 figurbildene
        {
            lFigurspillPoeng.Text = Convert.ToString(Poeng);
            switch (rnd)
            {
                case 0: pbFigurspill.Image = Læringsapplikasjon.Properties.Resources.LP_Trekant; break;
                case 1: pbFigurspill.Image = Læringsapplikasjon.Properties.Resources.LP_Firkant; break;
                case 2: pbFigurspill.Image = Læringsapplikasjon.Properties.Resources.LP_Sirkel; break;
                case 3: pbFigurspill.Image = Læringsapplikasjon.Properties.Resources.LP_Stjerne; break;
                case 4: pbFigurspill.Image = Læringsapplikasjon.Properties.Resources.LP_Femkant; break;
            }
            pbFigurspill.Location = new Point(372, 12);
            FigurspillTimer.Start();
        }

        #endregion

        private void btSpillmenyS_Click(object sender, EventArgs e) //sjekker hvilket spill man åpner fra spillmenyen
        {
            Random rnd = new Random();

            switch (lNavnSpill.Text)
            {
                case "Figurspill": lFigurspillFeilEllerRiktig.Text = ""; pFigurspill.Visible = true; pFigurspill.Dock = DockStyle.Fill; RandomFigurInt = rnd.Next(6); HvilkenFigurSkalVises(RandomFigurInt); break;
            }
        }
    }
}
