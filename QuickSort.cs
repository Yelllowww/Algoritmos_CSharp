using System;
using System.ComponentModel;
using System.Reflection;
class Program4
{
    public static int Particionar(double[] lista, int esquerda, int direita)
    {
        double pivo = lista[(esquerda + direita) / 2];
        while (esquerda <= direita)
        {
            while (lista[esquerda] < pivo)
            {
                esquerda++;
            }
            while (lista[direita] > pivo)
            {
                direita--;
            }
            if (esquerda <= direita)
            {
                double temp = lista[esquerda];
                lista[esquerda] = lista[direita];
                lista[direita] = temp;
                esquerda++;
                direita--;
            }
        }
        return esquerda;
    }
     public static void QuickSort(double[] lista, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int posicao = Particionar(lista, esquerda, direita);
            QuickSort(lista, esquerda, posicao - 1);
            QuickSort(lista, posicao + 1, direita);
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
                
                QuickSort(lista, 0, lista.Length - 1);

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

                QuickSort(lista, 0, lista.Length - 1);

                Console.WriteLine("Array ordenado:");
                Console.WriteLine(string.Join(", ",lista));
                Console.WriteLine();
            }
        }
    }
}
