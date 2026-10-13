using System;

namespace _TallerProgramación_modular
{
    internal class Program
    {

        /* Desarrolla un programa que permita: 
        Ingresar una palabra 
        LLevar la palabra ingresada a un vector de caracteres 
        Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
        usuario. */
        static void Main(string[] args)
        {

            Instruccíon();
            IngresarPalabra();
            LongitudPalabra(IngresarPalabra());

            
        }

        static void LongitudPalabra(string palabra)
        {
            palabra = IngresarPalabra();
            int cantidad = palabra.Length;
            char[] Linea;
            Linea = new char[cantidad];

            Console.WriteLine($"{cantidad}");

        }
        static string IngresarPalabra()
        {
            return Console.ReadLine();
        }

        static void Instruccíon()
        {
            Console.WriteLine("Ingrese una palabra porfavor");
        }
      
        

    }
}
