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

        Graphics graphics;
        Timer timer = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
        }
    }
}
