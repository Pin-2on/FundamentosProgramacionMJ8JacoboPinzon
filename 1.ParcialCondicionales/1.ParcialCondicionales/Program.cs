using System;
using System.Diagnostics.Eventing.Reader;

namespace _1.ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            A continuación, encontrará el enunciado que debe utilizar para realizar un programa en C#, que dé solución al problema allí planteado. (70%)

            //Un conjunto de personas debe ser clasificado en uno de cuatro grupos: A, B, C o D, de acuerdo con diferentes características de la persona.
            //La clasificación se realizará teniendo en cuenta el sexo, la edad, el último dígito del documento de identidad y, únicamente en un caso específico, el dominio del idioma inglés.
            //Reglas de clasificación
            //Grupo A
            //Una persona pertenece al grupo A si cumple alguna de las siguientes condiciones:
            //Es mujer, tiene entre 16 y 20 años, inclusive, y el último dígito de su documento de identidad es 0, 4 u 8.
            //Es hombre, tiene entre 18 y 22 años, inclusive, y el último dígito de su documento de identidad es 1, 5 o 9.
            //Grupo B
            //Una persona pertenece al grupo B si cumple alguna de las siguientes condiciones:
            //            Es mujer, tiene entre 21 y 25 años, inclusive, y el último dígito de su documento de identidad es 3 o 7.
            //Es hombre, tiene entre 23 y 26 años, inclusive, y el último dígito de su documento de identidad es 2 o 6.
            //Grupo C
            //Una persona pertenece al grupo C si:
            //            Tiene exactamente 15 años, y
            //            Domina el idioma inglés.
            //            Importante: el programa solo debe solicitar información sobre el dominio del idioma inglés cuando la persona tenga exactamente 15 años.Para las personas de cualquier otra edad, esta información no debe ser solicitada.
            //Grupo D
            //Una persona pertenece al grupo D cuando no cumple ninguna de las condiciones establecidas para los grupos A, B o C.
            //Los grupos son excluyentes, por lo que cada persona debe ser clasificada en un único grupo.
            //Objetivo
            //Desarrolle un programa en C# que:
            //Solicite el sexo de la persona(masculino o femenino).
            //Solicite la edad, como un número entero positivo.
            //Solicite el último dígito del documento de identidad, que debe ser un número entre 0 y 9.
            //Si la persona tiene 15 años, solicite además si domina el idioma inglés(sí o no).
            //Analice la información ingresada y determine el grupo al que pertenece la persona.
            //Muestre en pantalla el grupo correspondiente: A, B, C o D.
            //Nota: El programa debe utilizar adecuadamente estructuras condicionales para tomar las decisiones necesarias y debe evitar solicitar información que no sea necesaria para determinar la clasificación.

            //2.Crear los casos de prueba, y realizar la prueba de escritorio. (30 %).


            string sexo;
            int edad = 0;
            int docnum = 0;

            Console.WriteLine("Bienvenido, a continuación le solicitaremos unos datos para clasificarlo en uno de nuestros 4 grupos");
            Console.WriteLine("Ingrese su sexo (Masculino, Femenino, Otro)");
            sexo = Convert.ToString(Console.ReadLine());

          
            Console.WriteLine("Ingrese su edad");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el último digito de su documento de identidad");
                docnum = Convert.ToInt32(Console.ReadLine());

                if (sexo == "femenino" || sexo == "Femenino")
                {
                    if (edad >= 16 && edad <= 20)
                    {
                        if (docnum == 0 || docnum == 4 || docnum == 8)
                        {
                            Console.WriteLine("Ústed pertenece al grupo A");
                        }
                        else
                        {
                            Console.WriteLine("Ústed pertenece al grupo D");
                        }


                    }
                    if (edad >= 21 && edad <= 25)
                    {
                        if (docnum == 3 || docnum == 7)
                        {

                            Console.WriteLine("Ústed pertenece al grupo A");

                        }
                        else
                        {
                            Console.WriteLine("Ústed pertenece al grupo D");
                        }
                    }
                }
                if (sexo == "masculino" || sexo == "Masculino")
                {
                    if (edad >= 18 && edad <= 22)
                    {
                        if (docnum == 1 || docnum == 5 || docnum == 9)
                        {

                            Console.WriteLine("Ústed pertenece al grupo A");

                        }
                        else
                        {
                            Console.WriteLine("Ústed pertenece al grupo D");
                        }

                    }
                    if (edad == 23 || edad == 26)
                    {

                        if (docnum == 2 || docnum == 6)
                        {

                            Console.WriteLine("Ústed pertenece al grupo A");

                        }
                        else
                        {
                            Console.WriteLine("Ústed pertenece al grupo D");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Ústed pertenece al grupo D");
                }


                if (edad == 15)
                {
                    Console.WriteLine("¿Domina ústed el idioma íngles? (SI/NO)");

                    string respuesta;

                    respuesta = Convert.ToString(Console.ReadLine());

                    if (respuesta == "NO" || respuesta == "No" || respuesta == "no")
                    {
                        Console.WriteLine("Ústed pertenece al grupo D");
                    }
                    else
                    {
                        Console.WriteLine("Ústed pertenece al grupo C");
                    }
                }
          

        }
    }
}