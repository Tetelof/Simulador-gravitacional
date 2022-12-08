using System;
using System.IO;

namespace Simulador_gravitacional
{
    public class Parametros
    {
        public int QtdCorpos { get; set; }
        public int QtdInteracoes { get; set; }
        public int TempoEntreInteracoes { get; set; }
        public Planeta[] Planetas { get; set; }
        public Parametros()
        {
            StreamReader sr = new("./arquivo.txt");
            string[] valores = sr.ReadLine().Split(";");
            this.QtdCorpos = Convert.ToInt32(valores[0]);
            this.QtdInteracoes = Convert.ToInt32(valores[1]);
            this.TempoEntreInteracoes = Convert.ToInt32(valores[2]);
            this.Planetas = new Planeta[this.QtdCorpos];
            for (int i =0; !sr.EndOfStream; i++)
            {
                valores = sr.ReadLine().Split(";");
                this.Planetas[i] = new Planeta();
                this.Planetas[i].setNome(valores[0]);
                this.Planetas[i].setMassa(Convert.ToDouble(valores[1]));
                if (this.Planetas[i].getMassa() < 0 || this.Planetas[i].getMassa() < 1)
                {
                    throw new Exception($"Corpo {valores[0]} com massa fora do limite.");
                }
                this.Planetas[i].setDensidade(Convert.ToDouble(valores[2]));
                this.Planetas[i].setPosX(Convert.ToDouble(valores[3]));
                this.Planetas[i].setPosY(Convert.ToDouble(valores[4]));
                this.Planetas[i].setVelocidadeX(Convert.ToDouble(valores[5]));
                this.Planetas[i].setVelocidadeY(Convert.ToDouble(valores[6]));
            }
            sr.Close();
            if(this.Planetas.Length > 200)
            {
                throw new Exception("Quantidade de corpos maior que o limite de 200.");
            }
        }
        public Parametros(string path)
        {
            StreamReader sr = new(path);
            string[] valores = sr.ReadLine().Split(";");
            this.QtdCorpos = Convert.ToInt32(valores[0]);
            this.QtdInteracoes = Convert.ToInt32(valores[1]);
            this.TempoEntreInteracoes = Convert.ToInt32(valores[2]);
            this.Planetas = new Planeta[this.QtdCorpos];
            for (int i = 0; sr.EndOfStream; i++)
            {
                valores = sr.ReadLine().Split(";");
                this.Planetas[i] = new Planeta();
                this.Planetas[i].setNome(valores[0]);
                this.Planetas[i].setMassa(Convert.ToDouble(valores[1]));
                if (this.Planetas[i].getMassa() > 500 || this.Planetas[i].getMassa() < 1)
                {
                    throw new Exception($"Corpo {valores[0]} com massa fora do limite.");
                }
                this.Planetas[i].setDensidade(Convert.ToDouble(valores[2]));
                this.Planetas[i].setPosX(Convert.ToDouble(valores[3]));
                this.Planetas[i].setPosY(Convert.ToDouble(valores[4]));
                this.Planetas[i].setVelocidadeX(Convert.ToDouble(valores[5]));
                this.Planetas[i].setVelocidadeY(Convert.ToDouble(valores[6]));
            }
            sr.Close();
            if (this.Planetas.Length > 200)
            {
                throw new Exception("Quantidade de corpos maior que o limite de 200.");
            }
        }
    }
}
