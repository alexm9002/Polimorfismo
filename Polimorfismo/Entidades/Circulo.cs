using System;
using Polimorfismo.Entidades.Enums;
namespace Polimorfismo.Entidades
{
    class Circulo : Formas
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cores cores) : base(cores)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return Math.PI * (Raio * Raio);
        }
    }
}
