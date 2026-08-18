using Microsoft.Win32;
using System;
using System.Text;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio número 1
            /*            decimal num1= 0;
                        decimal num2= 0;
                        decimal num3= 0;
                        Console.WriteLine("-----------Escriba algunos números aca abajo porfa-----------");
                        Console.WriteLine("El primero");
                        num1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("El segundo...");
                        num2 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("El últimooo...");
                        num3 = decimal.Parse(Console.ReadLine());

                        if (num1==num2 || num1==num3 || num2==num3)
                        {
                            Console.WriteLine("¿Bro? ¿Cómo no vas a saber que se tienen que ingresar números diferentes? lol, hacelo de nuevo");
                        }
                        else
                        {
                            if(num1>=num2 && num1>=num3 && num2>=num3)//1>2>3
                            {
                                Console.WriteLine("El mayor es el:" + num1);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num1);
                                Console.WriteLine(num2);
                                Console.WriteLine(num3);
                            }
                            if (num1 >= num2 && num1 >= num3 && num2 <= num3)//1>3>2
                            {
                                Console.WriteLine("El mayor es el:" + num1);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num1);
                                Console.WriteLine(num3);
                                Console.WriteLine(num2);
                            }
                            if (num1 <= num2 && num1 <= num3 && num2 <= num3)//2>1>3
                            {
                                Console.WriteLine("El mayor es el:" + num2);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num2);
                                Console.WriteLine(num1);
                                Console.WriteLine(num3);
                            }
                            if (num1 >= num2 && num1 <= num3 && num2 >= num3)//2>3>1
                            {
                                Console.WriteLine("El mayor es el:" + num2);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num2);
                                Console.WriteLine(num3);
                                Console.WriteLine(num1);
                            }
                            if (num1 >= num2 && num1 <= num3 && num2 <= num3)//3>1>2
                            {
                                Console.WriteLine("El mayor es el:" + num3);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num3);
                                Console.WriteLine(num1);
                                Console.WriteLine(num2);
                            }
                            if (num1 <= num2 && num1 >= num3 && num2 >= num3)//3>2>1
                            {
                                Console.WriteLine("El mayor es el:" + num3);
                                Console.WriteLine("Y el orden es:");
                                Console.WriteLine(num3);
                                Console.WriteLine(num2);
                                Console.WriteLine(num1);
                            }
                        }*/

            //-----------------------------------------------------------------------------------------------------------------------------------
            //Ejercicio número 2

            int municion = 0;
            string estado = "normal";

            Random rnd = new Random();
            municion = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
            Console.WriteLine("Ammo: " + municion);
            Console.WriteLine("Power up (Y/N)?");
            Console.ReadLine();
            
            
            //Insertar cambio de estado lol

            if (municion >= 0)
            {
                Console.WriteLine("piu piu");
            }
            else
            {
                if(municion == 0)
                {
                    Console.WriteLine("NO AMMO");
                }
            }
           

        }
    }
}
