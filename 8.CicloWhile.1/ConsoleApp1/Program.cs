using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar una patalla con el total de la suma de los números ingresados

            int SumaEnterosPositivos = 0; //Acumulador
            int numero = 0;

            Console.WriteLine("Ingrese un número para sumar, Ingrese -1 para terminar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                SumaEnterosPositivos += numero;
                Console.WriteLine("Ingrese un número para sumar, Ingrese -1 para terminar");
                numero = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"La suma de los números positivos ingresados es: {SumaEnterosPositivos}");

        }
    }
}
