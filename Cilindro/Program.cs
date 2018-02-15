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
            float a, r;
            const float PI = 3.1415926f;
            Console.Write("Digite a altura do cilindro:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite o raio do cilindro: ");
            r = Convert.ToSingle(Console.ReadLine());
        }
    }
}
