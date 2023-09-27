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
            int j = 0;
            char l = 'a';
            int m = 0;
            int x = 0;
            Console.WriteLine("Dame un numero para el array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            for (i = 0; i < n; i++)
            {
                numeros[i] = j++;
            }
            foreach (int elemento in numeros)
            {
                Thread.Sleep(150);
                Console.Write(elemento+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Ahora el alfabeto");
            char[] alfabeto = new char[26];
            //char[] alfabeto = {'a','e','i','o','u'};
            //alfabeto[0] = 'a';
            Console.WriteLine();
            for (m =0; m < 26; m++)
            {
                Thread.Sleep(150);
                Console.Write(m);
                Console.Write(l + " ");
                alfabeto[m] = l++;
            }
            Console.WriteLine();
            foreach (char letras in alfabeto)
            {
                Thread.Sleep(150);
                Console.Write(letras + " ");
            }
            Console.WriteLine();

            for (x = 0; x < alfabeto.Length; x++)
            {
                Thread.Sleep(150);
                Console.Write(x);
                Console.Write(alfabeto[x] + " ");
            }
            Console.ReadKey();
            

        }
    }
}
