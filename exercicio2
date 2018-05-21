using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Série de Fibonacci");

            Console.WriteLine("Digite o n−ésimo termo que você quer:");
            int A = Convert.ToInt32(Console.ReadLine());
            int[] bob = new int[A];
            bob[0] = 1;
            int ant = 0;

            for (int i = 0; i <= (A - 1); i++)
            {
                if (i != (A - 1))
                {
                    bob[i + 1] = bob[i] + ant;
                }

                ant = bob[i];
            }

            Console.WriteLine("O n-ésimo termo é: {0}", bob[A - 1]);

            Console.ReadKey();
        }
    }
}
