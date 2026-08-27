using System;
using System.IO;

namespace _9.CicloWhile._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // //Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir. El algoritmo debe escribir:
            // //La catidad de números introducidos mayores a 0. La cantidad de números introducidos menores que 0. la cantidad de números iguales a 0.

            // int CantidadNum = 0;
            // int NumIngresado = 0;
            // int NumContador = 1;

            // int NumMayor0 = 0;
            // int NumIgual0 = 0;
            // int NumMenor0 = 0;


            // Console.WriteLine("Ingrese la cantidad de números que desea ingresas (ud vera cuanto se queda aca");
            // CantidadNum = int.Parse(Console.ReadLine());

            // if (CantidadNum < 0)
            // {

            //     Console.WriteLine("Tan chistoso, Ingrese uno positivo");

            // }


            // Console.WriteLine("Ingrese el número que usted desee (De cualquier signo)");

            // NumIngresado = int.Parse(Console.ReadLine());

            // while (NumIngresado > 0 && CantidadNum != NumContador)
            // {

            //         NumMayor0 += 1;
            //         Console.WriteLine("Ingrese el número que usted desee (De cualquier signo)");
            //         NumIngresado = int.Parse(Console.ReadLine());

            //         NumContador += 1;

            // }

            //while (NumIngresado == 0 && CantidadNum != NumContador)
            //{

            //         NumIgual0 += 1;
            //         Console.WriteLine("Ingrese el número que usted desee (De cualquier signo)");
            //         NumIngresado = int.Parse(Console.ReadLine());

            //         NumContador += 1;

            //}

            //while (NumIngresado < 0 && CantidadNum != NumContador)
            //{

            //         NumMenor0 += 1;
            //         Console.WriteLine("Ingrese el número que usted desee (De cualquier signo)");
            //         NumIngresado = int.Parse(Console.ReadLine());

            //         NumContador += 1;

            //}


            //     Console.WriteLine($"Numeros mayores a 0: {NumMayor0}");
            //     Console.WriteLine($"Numeros iguales a 0: {NumIgual0}");
            //     Console.WriteLine($"Numeros menor a 0: {NumMenor0}");


            int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;

            Console.WriteLine("Ingrese la cantidad de números a evaluar");

            cantidadNumeros = int.Parse(Console.ReadLine());

            while (cantidadNumeros > contador)
            {

                contador++;
                Console.WriteLine("ingrese el número a evaluar");
                numero = int.Parse(Console.ReadLine());


                if(numero < 0)
                {

                    contadorNegativos++;
                }
                else
                {
                    if(numero == 0)
                    {
                        contadorCeros++;
                    }
                    else
                    {

                        contadorPositivos++;

                    }

                }

            }


            Console.WriteLine($"Cantidad Positivos: {contadorPositivos}. Cantidad Negativos: {contadorNegativos}. Cantidad Ceros: {contadorCeros}");

        }
    }
}
