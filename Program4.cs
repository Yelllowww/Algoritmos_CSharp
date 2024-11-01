using System;
using System.ComponentModel;
using System.Reflection;
class Program4
{
    public static void BubbleSort(double[] lista)
    {
        double temp;

        for(int i = 0; i < lista.Length - 1; i++)
        {
            for(int j = 0; j < lista.Length - (1 + i); j++)
            {
                if (lista[j] > lista[j+1])
                {
                    temp = lista[j+1];
                    lista[j+1] = lista[j];
                    lista[j] = temp;
                }
            }
        }
    }
    static void Main()
    {
        Random num = new Random();
        while (true)
        {
            Console.WriteLine("Digite o tamanho da lista:");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            double[] lista = new double[tamanho];
            Console.WriteLine("aperte 0 para usar números aleatórios, -1 para sair e -2 para inserir manualmente: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input == 0)
            {
                for (int e = 0; e < tamanho; e++)
                {
                    lista[e] = num.Next(0, tamanho + 1);
                }
                Console.WriteLine("Array original:");
                Console.WriteLine(string.Join(", ",lista));
                Console.WriteLine();
                
                BubbleSort(lista);

                Console.WriteLine("Array ordenado:");
                Console.WriteLine(string.Join(", ",lista));
                Console.WriteLine();
            }
            else if (input == -1)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Escreva os números a serem ordenados: ");
                for (int e = 0; e < tamanho; e++)
                {
                    double insere = Convert.ToDouble(Console.ReadLine());
                    lista[e] = insere;
                }
                Console.WriteLine("Array original:");
                Console.WriteLine(string.Join(", ",lista));

                BubbleSort(lista);

                Console.WriteLine("Array ordenado:");
                Console.WriteLine(string.Join(", ",lista));
                Console.WriteLine();
            }
        }
    }
}
