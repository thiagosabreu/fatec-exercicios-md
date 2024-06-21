using System;

namespace verificaAssimetrica
{
    public class verificaAssimetrica
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

            bool isAssimetrica = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (relacao[i, j] == relacao[j, i])
                    {
                        isAssimetrica = false;
                        break;
                    }
                }
            }

            if (isAssimetrica)
            {
                Console.WriteLine("A relação é assimétrica.");
            }
            else
            {
                Console.WriteLine("A relação não é assimétrica.");
            }
        }
    }
}
