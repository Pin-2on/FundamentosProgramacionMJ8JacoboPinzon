using System;
using System.Security.Cryptography;
using System.Timers;

namespace _14.Tallerpreparacion_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee,
            //en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente


            //decimal Acunotas = 0;
            //decimal notas = 0;
            //int contador = 0;

            //decimal promedio;

            //do
            //{

            //    Console.WriteLine("Ingrese sus notas obtenidas (maximo 5), si desea parar, ingrese 6");
            //    notas = decimal.Parse(Console.ReadLine());

            //    if (notas <= 5)
            //    {
            //        Acunotas += notas;
            //        contador++;

            //    }

            //} while (notas <= 5);

            //promedio = Acunotas / contador;

            //Console.WriteLine($"El promedio de sus notas es: {promedio}");


            //2.Se requiere un algoritmo para mostrar por pantalla los divisores de un
            //número ingresado por teclado.
            //Tener en cuenta que dados dos números enteros a y b, se dice que b es
            //divisor de a si se cumple que al efectuar una división entera a/ b el
            //residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            //una división de dos números.
            //Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            //2, 1 que son los divisores del número 6.

            //int numero = 0;
            //int numerador = 0;
            //int contador = 1;
            //decimal division;

            //Console.WriteLine("Ingrese un numero entero para ver sus divisores");
            //numero = int.Parse(Console.ReadLine());

            //do
            //{
            //    division = numero % contador;

            //    if (division == 0)
            //    {
            //        numerador++;

            //        Console.WriteLine($"{numerador}. {contador}");

            //    }

            //    contador++;

            //} while (contador <= numero);

            //* 3. Dados dos números enteros ingresados por teclado: b que es la base y
            //e que es el exponente, se requiere calcular el resultado de la potenciación.
            //Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            //Mostrar por pantalla el resultado de la potenciación.
            //Seguir pidiendo por teclado la base y el exponente y realizar la
            //potenciación correspondiente, hasta que el usuario ingrese por teclado
            //el carácter de escape ‘n’ 

            //double num;
            //double exponente;
            //double proceso;

            //string escape;

            //do
            //{
            //    Console.WriteLine("Ingrese un numéro que actue de base para una potenciación");
            //num = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese un número que actue de exponente");
            //exponente = int.Parse(Console.ReadLine());

            //    proceso = Math.Pow(num, exponente);

            //    Console.WriteLine($"El resultado es {proceso}");

            //    Console.WriteLine("Desea continuar? para salir, ingrese n");
            //    escape = Console.ReadLine().ToLower();

            //} while (escape != "n");


        }
    }
}
