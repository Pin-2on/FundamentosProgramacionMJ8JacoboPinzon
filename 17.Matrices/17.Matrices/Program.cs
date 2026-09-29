using System;
using System.ComponentModel;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Diseñar un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor
            //Requerimientos: 1. Solicitar al usuario las dimensiones de la matriz. 2. Capturar los valores númericos para llenar la matriz
            //3. Solicitar el valor límite u objetivo (N). 4. Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento < N
            //5. Mostrar la matriz resultante

            int[,] matriz;
            int filas = 0;
            int columnas = 0;

            Console.WriteLine("Porfavor ingrese los limites para una matriz como un número entero mayor a 0 y menor a 11");
            Console.WriteLine("Ingrese número de filas para la matriz");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número de columnas para la matriz");
            columnas = int.Parse(Console.ReadLine());

            matriz = new int[filas, columnas];

            if (filas <= 0 || columnas <= 0 || filas >= 11 || columnas >= 11)
            {
                Console.WriteLine("error, ingrese bien los valores");
            }
            else
            {
                

                Console.WriteLine("Ingrese los valores para llenar la matriz porfavor");

                for (int x = 0; x < filas; x++)
                {
                    for (int y = 0; y < columnas; y++)
                    {
                        Console.WriteLine($"Ingrese el valor para la posición de la matriz [{x+1},{y+1}], x|{x}| y  |{y}|");
                        matriz[x, y] = int.Parse(Console.ReadLine());
            
                    }

                }
            }

            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    Console.WriteLine($"|{matriz[x, y]}|");
                }
            }


        
            





        }
    }
}
