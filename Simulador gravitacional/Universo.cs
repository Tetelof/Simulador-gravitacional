using System;

namespace Simulador_gravitacional
{
    abstract class Universo
    {
        public abstract double CalculoForçaGravitacional(Planeta planeta1, Planeta planeta2);
        public abstract double CalculoInteracoesGravitacionais(Planeta planeta1, Planeta planeta2);
        public abstract double CalculoDistanciaEntreCorpos(Planeta planeta1, Planeta planeta2);
    }
}
