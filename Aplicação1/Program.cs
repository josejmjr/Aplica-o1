using System;

namespace Aplicação1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a Quantidade de Números Inseridos");
            int qtdNumeros = Convert.ToInt32(Console.ReadLine());
            float[] numeros = new float[qtdNumeros];
            float soma = 0;
         
            for (int i = 0; i < qtdNumeros; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "° número");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma += numeros[i];
            }

            float media = soma / qtdNumeros;

            float max = numeros[0];
            float min = numeros[0];
            for (int i = 0; i < qtdNumeros; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < qtdNumeros; i++)
            {
                Console.WriteLine((i+1) + "° número recebido: " + numeros[i]);     
            }

            Console.WriteLine("\nMédia das Numeros: " + media);
            Console.WriteLine("Maior Numero : " + max);
            Console.WriteLine("Menor Numero: " + min);

            Console.ReadLine();

        }
    }
}
