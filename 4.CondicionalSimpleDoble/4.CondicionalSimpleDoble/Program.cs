using System;


namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte edad = 0;
            Console.WriteLine("ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si la condición es verdadera
                Console.WriteLine("Bienveinido a mi sitio web");

                Decimal money = 0; //lol pobreza
                Console.WriteLine("Dame tu plata (cuanta plata tenei, cuanto te pagai) [Pone decimale culiao]");
                money = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Ahora poneme tu nombre (No te pongas un nombre de kahoot");
                string nombre = Console.ReadLine();
                if (money >= 3000)
                {
                    Console.Write(money + "!? ");
                    Console.WriteLine(nombre + ", te vamos a mandar a la Dian/IRS cabron");
                }
                if (money <= 3000)
                {
                    Console.WriteLine("Ja, mero pobre");
                }
            }
            else
            {
                Console.WriteLine("Vete a la guarderia pequeño brainrot");
            } 

            //Esturctura de control condicional
            //Simple
            //1.    Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 años, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web".


            //2.    Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar con el nombre de la persona, indicando que debe abonar impuestos

            



            //Condicional Doble
            //Crea un algoritmo que lea la edad del usuario, si el usuario es mayor de 18, se debe mostras el siguiente mensaje "Bienvenido a mi sitio web" De lo contrario "usted no es apto para el contenido de este sitio"
        }
    }
}
