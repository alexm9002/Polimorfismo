using System;
using System.Collections.Generic;
using System.Globalization;
using Polimorfismo.Entidades;
using Polimorfismo.Entidades.Enums;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            List<Formas> lista = new List<Formas>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados da Forma #" + i + ":");
                Console.Write("Retângulo ou Círculo (R/C)? ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Informe a cor da forma (Black/Blue/Red): ");
                Cores cor = Enum.Parse<Cores>(Console.ReadLine());

                if (resposta == 'R' || resposta == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, cor));
                }
                else if (resposta == 'C' || resposta == 'c')
                {
                    Console.Write("Informe o Raio do Círculo: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio, cor));
                }
                else
                {
                    Console.WriteLine("Resposta Inválida!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Área das formas: ");
            foreach (Formas formas in lista)
            {
                Console.WriteLine(formas.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
