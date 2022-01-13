using Polimorfismo.Entidades.Enums;

namespace Polimorfismo.Entidades
{
    abstract class Formas
    {
        public Cores Cores { get; set; }

        public Formas(Cores cores)
        {
            this.Cores = cores;
        }

        public abstract double Area();
    }
}
