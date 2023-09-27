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
            char l = ' ';
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
                
                Console.Write(elemento+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Dame una letra para el array");
            char c = Convert.ToChar(Console.ReadLine());

            char[] alfabeto = new char[c];

            for (l = 'a'; l <= c; l++)
            {
                alfabeto[m++] = l;
            }
            foreach (char letras in alfabeto)
            {

                Console.Write(letras + " ");
            }
            for (x = 0; x < alfabeto.Length; x++)
            {

                Console.Write(alfabeto[x] + " ");
            }


            Console.ReadKey();
            

        }
    }
}
