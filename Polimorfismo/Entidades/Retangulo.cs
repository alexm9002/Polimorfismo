using Polimorfismo.Entidades.Enums;
namespace Polimorfismo.Entidades
{
    class Retangulo : Formas
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura, Cores cores) : base(cores)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
