namespace Ejercicio1;
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = random.Next(1, 100); // Crear los numeros ramdom de 0 a 100
            }
        }

        int EsquinasSuma = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4]; // se utilizan coordenadas para la suma de las esquinas


        
        PrintMatriz(matriz);

        Console.WriteLine("Suma de las esquinas: " + EsquinasSuma);
    }

    static void PrintMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}
