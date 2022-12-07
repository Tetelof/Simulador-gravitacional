using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_gravitacional
{
    class UniversoReal : Universo
    {
        public const double G = 6.6743e-11; // constante gravitacional
        public override double CalculoDistanciaEntreCorpos(Planeta planeta1, Planeta planeta2)
        {
            double x2 = Math.Pow(planeta1.getPosX() - planeta2.getPosX(), 2);
            double y2 = Math.Pow(planeta1.getPosY() - planeta2.getPosY(), 2);
            return Math.Sqrt(x2 + y2);
        }

        public override double CalculoForçaGravitacional(Planeta planeta1, Planeta planeta2)
        {
            double distancia = this.CalculoDistanciaEntreCorpos(planeta1, planeta2);
            double Forca = G * (planeta1.getMassa() * planeta2.getMassa()) / Math.Pow(distancia, 2);
            return Forca;

            // planeta1.ForcaX += Forca * (planeta2.getPosX() - planeta1.getPosX()) / distancia;
            // planeta1.ForcaY += Forca * (planeta2.getPosY() - planeta1.getPosY()) / distancia;
        }

        public override double CalculoInteracoesGravitacionais(Planeta planeta1, Planeta planeta2)
        {
            throw new NotImplementedException();
        }
        
        public Planeta GetPlaneta(index)
        {
            throw new NotImplementedException();
        }
    }
}
