using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Escribir un algoritmo que permita generar los primeros 5 números enteros positivos y realizar y mostrar su suma
            //int contador = 1;
            //int acumulador = 1;

            //while (contador<5)
            //{
            //    contador++;
            //    acumulador = acumulador + contador;
            //}

            //Console.WriteLine($"la suma de los primeros 5 números enteros positivos es {acumulador}");

            //crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5*)

            int numero = 0;
            int factorial = 1;

            Console.WriteLine("Ingrese un número entero");

            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > -1) 
            {

                factorial = numero;


            }

        }
    }
}
