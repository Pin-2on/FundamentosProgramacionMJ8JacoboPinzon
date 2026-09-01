using System;
using System.IO;


namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////CicloDo While
            //int contador = 1;
            //int acumulador 0;

            //do
            //{
            //    acumulador += contador;
            //    contador++;
            //} while (contador <= 5);

            //Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");

            //int numero = 0;
            //int contador = 1;
            //int acumulador = 0;

            //string No;



            //Console.WriteLine("Porvafor Ingrese un número entero");

            //numero = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Tabla de multiplicar de {numero}");

            //do
            //{
            //    acumulador++;
            //    Console.WriteLine($"{contador}. {numero * acumulador}");
            //    contador++;

            //} while (contador <= 10);

            //Console.WriteLine("¿Quiere generar otra tabla (Si o no)?");
            //No = Convert.ToString(Console.ReadLine());

            //while (No == "Si" || No == "si")
            //{
            //    numero = 0;
            //    contador = 1;
            //    acumulador = 0;

            //    No = "";

            //    Console.WriteLine("Porvafor Ingrese un número entero");

            //    numero = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Tabla de multiplicar de {numero}");

            //    do
            //    {
            //        acumulador++;
            //        Console.WriteLine($"{contador}. {numero * acumulador}");
            //        contador++;

            //    } while (contador <= 10);

            //    Console.WriteLine("¿Quiere generar otra tabla (Si o no)?");
            //    No = Convert.ToString(Console.ReadLine());
            //    }

            string no;
            int contador = 1;
            int numero = 0;
            int divisor = 1;
            divisor = 1;


            Console.WriteLine("¿Calcular Primos? lol (No/si)");

            no = Convert.ToString(Console.ReadLine());

            if (no == "si" || no == "SI" || no == "Si")
            {

                do
                {
                    numero++;


                    contador++;

                    Console.WriteLine($"{numero}");

                } while (contador <= 100);



            }
        }
    }
}
