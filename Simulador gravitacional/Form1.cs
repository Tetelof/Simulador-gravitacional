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
        UniversoReal Universo = new UniversoReal();
        
        Graphics graphics;
        Timer timer = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            Universo.Planetas = parametros.Planetas;
            Universo.Tempo = parametros.TempoEntreInteracoes;

            graphics = this.CreateGraphics();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
            
            for(int i =0; i< parametros.QtdCorpos; i++)
            {
                Planeta pl = Universo.GetPlaneta(i);
                if(pl == null)
                {
                    continue;
                }
                int prop = 2;
                double posX = pl.getPosX();
                double posY = pl.getPosY();
                graphics.DrawEllipse(
                    new Pen(Color.FromArgb(255,255,255)),
                    (int) (posX - pl.getRaio()) / prop,
                    (int) (posY - pl.getRaio()) / prop,
                    (int) (pl.getRaio() * 2) / prop,
                    (int) (pl.getRaio() * 2) / prop
                );
            }
            Universo.CalculoInteracoesGravitacionais();
        }
    }
}
