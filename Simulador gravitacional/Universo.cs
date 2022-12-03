using System;

namespace Simulador_gravitacional
{
    public abstract class Universo
    {
        public abstract double CalculoForçaGravitacional();
        public abstract double CalculoInteracoesGravitacionais();
        public abstract double CalculoDistanciaEntreCorpos();
    }
}
