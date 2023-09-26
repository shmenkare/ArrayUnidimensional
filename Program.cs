using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArrayUnidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            
            Console.WriteLine("Dame un numero para el array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            for (i = 0; i < n; i++)
            {
                numeros[i] = j++;
            }
            foreach (int elemento in numeros)
            {
                Thread.Sleep(300);
                Console.Write(elemento);
            
            }
            Console.ReadKey();

        }
    }
}
