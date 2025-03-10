using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static Random random = new Random();
    static void Shuffle(double[] lista)
    {
        for (int i = 0; i < lista.Length; i++)
        {
            int randomIndex = random.Next(lista.Length);
            (lista[i], lista[randomIndex]) = (lista[randomIndex], lista[i]);
        }
    }
    static bool ordena(double[]lista)
    {
        for (int i = 0; i < lista.Length - 1; i++)
        {
            if (lista[i] > lista[i + 1])
                return false;
        }
        return true;
    }
    static void BogoSort(double[]lista)
    {
        while (!ordena(lista))
        {
            Shuffle(lista);
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
                Console.WriteLine(string.Join(", ", lista));
                Console.WriteLine();

                BogoSort(lista);

                Console.WriteLine("Array ordenado:");
                Console.WriteLine(string.Join(", ", lista));
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
                Console.WriteLine(string.Join(", ", lista));

                BogoSort(lista);

                Console.WriteLine("Array ordenado:");
                Console.WriteLine(string.Join(", ", lista));
                Console.WriteLine();
            }
        }
    }
}
