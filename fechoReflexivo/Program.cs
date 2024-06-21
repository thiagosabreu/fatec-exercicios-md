using System;

namespace fechoReflexivo
{
    public class fechoReflexivo
    {
        public static void Main()
        {
            Console.Clear();
            Console.Write("Insira a ordem do conjunto: ");
            int n = int.Parse(Console.ReadLine());
            int[,] relacao = new int[n, n];

            Console.WriteLine("Insira a matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{i}, {j}] = ");
                    relacao[i, j] = (int.Parse(Console.ReadLine()) != 1) ? 0 : 1;
                }
            }

            Console.WriteLine("Conjunto inserido:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(relacao[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                relacao[i, i] = 1;
            }

            Console.WriteLine("Fecho reflexivo:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(relacao[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
