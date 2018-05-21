using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 10 valores inteiros:");
            int[] A = new int[10];
            int impar = 0;
            int par = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira algum valor:");
                A[i] = Convert.ToInt32((Console.ReadLine()));
            }

            foreach (var x in A)
            {
                if(x % 2 == 0)
                {
                    par++;
                } else
                {
                    impar++;
                }
            }

            Console.WriteLine("\n\nNúmeros impares: {0}", impar);
            Console.WriteLine("Números pares: {0}", par);

            Console.ReadKey();
        }
    }
}
