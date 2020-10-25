using System;
using System.Linq;

namespace Insercion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numbers = "5,57,8,9,14,55,62,4,1,3,0,25,48,96,33,24,56,45,89,87,97,78,98,54,65,45,21,54,89,65,32,54,512,63,64,26,36,874,13,321,328,99,87,456,546,21,58,98,52,31";

            int[] vector = numbers.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine();
            Console.WriteLine("Vector ordenado:");
            Console.WriteLine(string.Join(",", Ordenar(vector)));
            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir.");
            Console.ReadKey();
        }

        private static int[] Ordenar(int[] vector)
        {
            int auxiliar;

            for (int i = 1; i < vector.Length; i++)
            {
                auxiliar = vector[i];

                for (int j = i - 1; j >= 0 && vector[j] > auxiliar; j--)
                {
                    vector[j + 1] = vector[j];
                    vector[j] = auxiliar;
                }
            }

            return vector;
        }
    }
}
