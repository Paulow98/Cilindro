using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r;

            Console.Write("Digite a altura do cilindro:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite o raio do cilindro: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n Volume:" + volume(a, r) + "\n Area da Superficie:" + areaDaSuperficie(a, r));

            Console.ReadKey();
        }

        static double volume(double altura, double raio)
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
        static double areaDaSuperficie(double altura, double raio)
        {
            return 2 * Math.PI * raio * (raio + altura);
        }
    }
}
