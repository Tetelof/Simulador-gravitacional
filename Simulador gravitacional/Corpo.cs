using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_gravitacional
{
    abstract class Corpo
    {
        protected string Nome;
        protected double Massa;
        protected double Densidade;
        protected double PosX;
        protected double PosY;
        protected double VelX;
        protected double VelY;
        public abstract string getNome();
        public abstract void setNome(string nome);
        public abstract double getMassa();
        public abstract void setMassa(double massa);
        public abstract double getVelocidadeX();
        public abstract void setVelocidadeX(double velocidade_x);
        public abstract double getVelocidadeY();
        public abstract void setVelocidadeY(double velocidade_y);
        public abstract double getRaio();
        public abstract double getPosX();
        public abstract void setPosX(double pos_x);
        public abstract double getPosY();
        public abstract void setPosY(double pos_x);
        public abstract double getDensidade();
        public abstract void setDensidade(double densidade);
        public abstract double getForcaX();
        public abstract void setForcaX(double forca_x);
        public abstract double getForcaY();
        public abstract void setForcaY(double forca_y);
    }
}
