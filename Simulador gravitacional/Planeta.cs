using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_gravitacional
{
    public class Planeta : Corpo
    {
        public const double PI = 3.14159265359;
        public override double getDensidade()
        {
            return this.Densidade;
        }

        public override double getForcaX()
        {
            return this.ForcaX;
        }

        public override double getForcaY()
        {
            return this.ForcaY;
        }

        public override double getMassa()
        {
            return this.Massa;
        }

        public override string getNome()
        {
            return this.Nome;
        }

        public override double getPosX()
        {
            return this.PosX;
        }

        public override double getPosY()
        {
            return this.PosY;
        }

        public override double getRaio()
        {
            double volume = Massa / Densidade;
            double raio3 = volume / (4d / 3d * PI);
            double raio = Math.Pow(raio3, 1d / 3d);
            return raio;
        }

        public override double getVelocidadeX()
        {
            return this.VelX;
        }

        public override double getVelocidadeY()
        {
            return this.VelY;
        }

        public override void setDensidade(double densidade)
        {
            this.Densidade = densidade;
        }

        public override void setForcaX(double forca_x)
        {
            this.ForcaX = forca_x;
        }

        public override void setForcaY(double forca_y)
        {
            this.ForcaY = forca_y;
        }

        public override void setMassa(double massa)
        {
            this.Massa = massa;
        }

        public override void setNome(string nome)
        {
            this.Nome = nome;
        }

        public override void setPosX(double pos_x)
        {
            this.PosX = pos_x;
        }

        public override void setPosY(double pos_y)
        {
            this.PosY = pos_y;
        }

        public override void setVelocidadeX(double velocidade_x)
        {
            this.VelX = velocidade_x;
        }

        public override void setVelocidadeY(double velocidade_y)
        {
            this.VelY = velocidade_y;
        }

        public static Planeta operator +(Planeta a, Planeta b)
        {
            a.Massa = a.Massa + b.Massa;
            a.VelX = a.VelX + b.VelY;
            a.VelY = a.VelY + b.VelY;
            return a;
        }
    }
}
