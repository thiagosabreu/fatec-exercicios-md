using System;

namespace fechoTransitivo
{
    public class fechoTransitivo
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("Insira a ordem do grafo: ");
            int n = int.Parse(Console.ReadLine());
            int[,] grafo = new int[n, n];

            Console.WriteLine("Insira a matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{i}, {j}] = ");
                    grafo[i, j] = (int.Parse(Console.ReadLine()) != 1) ? 0 : 1;
                }
            }

            Console.WriteLine("Conjunto inserido:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(grafo[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        grafo[i, j] = grafo[i, j] | (grafo[i, k] & grafo[k, j]);
                    }
                }
            }

            Console.WriteLine("Fecho transitivo:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(grafo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
