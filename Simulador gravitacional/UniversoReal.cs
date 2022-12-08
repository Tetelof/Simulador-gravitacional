using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_gravitacional
{
    public class UniversoReal : Universo
    {
        public const double G = 6.6743e-11; // constante gravitacional
        public double Tempo { get; set; }
        public Planeta[] Planetas{ get; set; }
        public override double CalculoDistanciaEntreCorpos(Planeta planeta1, Planeta planeta2)
        {
            double x2 = Math.Pow(planeta1.getPosX() - planeta2.getPosX(), 2);
            double y2 = Math.Pow(planeta1.getPosY() - planeta2.getPosY(), 2);
            return Math.Sqrt(x2 + y2);
        }

        public override void CalculoForçaGravitacional(Planeta planeta1, Planeta planeta2)
        {
            double distancia = this.CalculoDistanciaEntreCorpos(planeta1, planeta2);
            if (distancia < planeta1.getRaio())
            {
                planeta1 = planeta1 + planeta2;
                planeta2 = null;
                return;
            }
            double Forca = G * (planeta1.getMassa() * planeta2.getMassa()) / Math.Pow(distancia, 2);

            double forcaX = Forca * (planeta2.getPosX() - planeta1.getPosX()) / distancia;
            double forcaY = Forca * (planeta2.getPosY() - planeta1.getPosY()) / distancia;
            planeta1.setForcaX(planeta1.getForcaX() + forcaX);
            planeta1.setForcaY(planeta1.getForcaY() + forcaY);
        }

        public override void CalculoInteracoesGravitacionais()
        {
            for (int i = 0; i < this.Planetas.Length; i++)
            {
                for (int j = 0; j < this.Planetas.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (this.Planetas[i] != null && this.Planetas[j] != null)
                    {
                        this.CalculoForçaGravitacional(this.Planetas[i], this.Planetas[j]);
                    }
                }
            }
            foreach (Planeta planeta in this.Planetas)
            {
                if (planeta != null)
                {
                    this.CalcularPosicao(planeta);
                    this.CalcularVelocidade(planeta);
                    planeta.setForcaX(0);
                    planeta.setForcaY(0);
                }
            }
        }
        
        public Planeta GetPlaneta(int index)
        {
            return Planetas[index];
        }

        public void CalcularPosicao(Planeta planeta)
        {
            double posx = (planeta.getVelocidadeX() * Tempo) + (((planeta.getForcaX() / planeta.getMassa()) / 2) * (Tempo * Tempo)); //109.67+ (-1.62149) * 100
            double posy = (planeta.getVelocidadeY() * Tempo) + (((planeta.getForcaY() / planeta.getMassa()) / 2) * (Tempo * Tempo));

            planeta.setPosX(planeta.getPosX() + posx); //1264.39165689528285
            planeta.setPosY(planeta.getPosY() + posy); //391.2458414005469
        }
        public void CalcularVelocidade(Planeta planeta)
        {
            double velX = planeta.getVelocidadeX() + planeta.getForcaX() * planeta.getMassa();
            double velY = planeta.getVelocidadeY() + planeta.getForcaY() * planeta.getMassa();
            planeta.setVelocidadeX(velX);
            planeta.setVelocidadeY(velY);
        }
    }
}
