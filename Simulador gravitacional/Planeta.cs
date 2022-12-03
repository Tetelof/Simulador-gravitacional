using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_gravitacional
{
    class Planeta : Corpo
    {
        public override double getDensidade()
        {
            throw new NotImplementedException();
        }

        public override double getForcaX()
        {
            throw new NotImplementedException();
        }

        public override double getForcaY()
        {
            throw new NotImplementedException();
        }

        public override double getMassa()
        {
            throw new NotImplementedException();
        }

        public override string getNome()
        {
            throw new NotImplementedException();
        }

        public override double getPosX()
        {
            throw new NotImplementedException();
        }

        public override double getPosY()
        {
            throw new NotImplementedException();
        }

        public override double getRaio()
        {
            throw new NotImplementedException();
        }

        public override double getVelocidadeX()
        {
            throw new NotImplementedException();
        }

        public override double getVelocidadeY()
        {
            throw new NotImplementedException();
        }

        public override void setDensidade(double densidade)
        {
            throw new NotImplementedException();
        }

        public override void setForcaX(double forca_x)
        {
            throw new NotImplementedException();
        }

        public override void setForcaY(double forca_y)
        {
            throw new NotImplementedException();
        }

        public override void setMassa(double massa)
        {
            throw new NotImplementedException();
        }

        public override void setNome(string nome)
        {
            throw new NotImplementedException();
        }

        public override void setPosX(double pos_x)
        {
            throw new NotImplementedException();
        }

        public override void setPosY(double pos_x)
        {
            throw new NotImplementedException();
        }

        public override void setVelocidadeX(double velocidade_x)
        {
            throw new NotImplementedException();
        }

        public override void setVelocidadeY(double velocidade_y)
        {
            throw new NotImplementedException();
        }

        public static Planeta operator +(Planeta a, Planeta b)
        {
            Planeta c = new Planeta
            {
                Massa = a.getMassa() + b.getMassa(),
                PosX = a.PosX,
                PosY = a.PosY,
                VelX = a.VelX + b.VelY,
                VelY = a.VelY + b.VelY
            };
            return c;
        }
    }
}
