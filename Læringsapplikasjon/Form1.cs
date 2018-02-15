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



        private void mh(object sender, EventArgs e)
        {

        }

        private void FigurTimer_Tick(object sender, EventArgs e)
        {

        }



        private void StartmenyHover(object sender, EventArgs e) //hover
        {
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

        private void StartmenyClick(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            if (bt == btStartF)
            {
                hvilketSpill = 0;

            }
        }
    }
}
