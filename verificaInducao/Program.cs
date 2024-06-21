using System;

namespace verificaInducao
{
    public class verificaInducao
    {
        public static void Main()
        {
            bool valido = true;

            Console.Clear();
            Console.Write("Verifique se a soma dos primeiros 'n' números naturais é igual a 'n(n + 1)/2'.\n");
            Console.Write("Insira o valor de n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Insira um número não negativo.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                int soma = i * (i + 1) / 2;
                int somaAtual = 0;
                for (int j = 1; j <= i; j++)
                {
                    somaAtual += j;
                }
                if (soma != somaAtual)
                {
                    valido = false;
                    break;
                }
            }

            if (valido)
            {
                Console.WriteLine("A propriedade é válida para todos os valores de 1 a " + n);
            }
            if (!valido)
            {
                Console.WriteLine("A propriedade não é válida para algum valor de 1 a " + n);
            }
        }
    }
}


