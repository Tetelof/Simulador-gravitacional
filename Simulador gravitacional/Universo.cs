using System;

namespace Simulador_gravitacional
{
    public abstract class Universo
    {
        public abstract void CalculoForçaGravitacional(Planeta planeta1, Planeta planeta2);
        public abstract void CalculoInteracoesGravitacionais();
        public abstract double CalculoDistanciaEntreCorpos(Planeta planeta1, Planeta planeta2);
    }
}
