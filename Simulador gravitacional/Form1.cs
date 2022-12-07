using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_gravitacional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Parametros parametros = new Parametros();
        Graphics graphics;
        Timer timer = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            timer.Interval = parametros.TempoEntreInteracoes;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);

            for(int i =0; i< parametros.QtdCorpos; i++)
            {

                Planeta pl = UniversoReal.GetPlaneta(i);
                if(pl == null)
                {
                    continue;
                }
                double posX = pl.GetPosX();
                double posY = pl.GetPosY();
                graphics.DrawEllipse(
                    new Pen(Color.FromArgb(255,255,255)),
                    (double) (posX - pl.GetRaio()) / prop,
                    (double) (posY - pl.GetRaio()) / prop,
                    (double) (pl.GetRaio() * 2) / prop,
                    (double) (pl.GetRaio() * 2) / prop
                );
            }
        }
    }
}
