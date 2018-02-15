using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        const float PI = 3.1415926f;
        static void Main(string[] args)
        {
            float a, r;
            
            Console.Write("Digite a altura do cilindro:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite o raio do cilindro: ");
            r = Convert.ToSingle(Console.ReadLine());
        }

        float volume(float altura, float raio)
        {
            return PI * (float)Math.Pow(raio,2) * altura;
        }
        float areaDaSuperficie(float altura, float raio)
        {
            return 2 * PI * raio * (raio + altura);
        }
    }
}
