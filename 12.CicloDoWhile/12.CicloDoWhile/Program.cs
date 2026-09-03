using System;


namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            decimal acumulador = 0;
            string nombre;
            int numcuenta = 0;
            decimal saldo = 0;
            string no;

            decimal promedio;

            do
            {
                Console.WriteLine("Porfavor ingrese su nombre");
                nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Porfavor ingrese su número de cuenta");
                numcuenta = int.Parse(Console.ReadLine());


                Console.WriteLine("Porfavor ingrese su saldo");
                saldo = int.Parse(Console.ReadLine());
                
                if(numcuenta > 300000)
                {

                    Console.WriteLine($"{nombre}, {numcuenta}, {saldo}. Es apto para el crédito");

                }
                else
                {

                    Console.WriteLine($"{nombre}, {numcuenta}, {saldo}. No es apto para el crédito");

                }

                contador++;
                acumulador += saldo;

                Console.WriteLine("¿Quiere ingresar otros datos? (Si o no)?");
                no = Console.ReadLine().ToLower(); //to lower convirte todas las respuestas/los caracteres en minusculas

            } while (no == "si" || no =="sipirili");

            promedio = acumulador / contador;

            Console.WriteLine($"número de usuarios preguntados: {contador}. promedio de los saldos: {promedio}");

        }
    }
}
