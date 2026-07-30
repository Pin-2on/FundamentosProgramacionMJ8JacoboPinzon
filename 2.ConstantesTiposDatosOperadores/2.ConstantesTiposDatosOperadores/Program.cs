using System;
using System.IO;

namespace _2.ConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string Iva="19%";
            string nombre = "Jacobo";
            nombre = "Ola";
            //Iva = "20%"; a una constante no le puedo cambiar el valor (o sea, lo que esta al principio no se puede hacer)
            //tipos de datos
            byte dato1 = 255;
            int dato2 = -12356;
            long dato3 = 123565656;
            float dato4 = 5.3f;
            double dato5 = 12.36d;
            decimal dato6 = 1235636.3265932353m;
            char dato7 = ' '; //solo colocar 1 caracter, si no, error
            string dato8 = "Dato8/";
            bool dato9 = true; //puede ser true o false
            object dato10 = new object();

            //Operadores
            //Operadores numericos
            //Cambio de singo
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}",dato11,dato12);
            //Operadores aritmeticos
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es:{0}",dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("La resta es:{0}",dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("El producto es:{0}",dato15);
            float dato16 = 5f / 3;
            Console.WriteLine("La división es:{0}",dato16);

        }
    }
}

