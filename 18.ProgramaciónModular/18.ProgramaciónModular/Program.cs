using System;


namespace _18.ProgramaciónModular
{
    internal class Program
    {

        static int añoactual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de fundamentos de programación");
            Console.ReadKey();
            BorrarPantalla();
            MostrarMensaje("Abuela");
            Console.WriteLine($"Tu Abueela tiene {CalcularEdad()}");
            MostrarMensaje("Tu", "Abuela");
        }

        //funciones con parametros
        static int CalcularEdad(int añoNacimiento, int añoActual) 
        {
            return añoNacimiento - añoActual;
        }

        //funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 1991;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        static void BorrarPantalla() 
        {
            Console.Clear();
        }

        static void MostrarMensaje(string nombre) 
        {

            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de programación");
        
        }

        static void MostrarMensaje( string nombre, string apellidos) 
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de programación");
        }

    }
}
