using System;
using System.Security.Cryptography;


namespace Parcial2Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //* Una institución educativa requiere un programa para procesar el rendimiento académico de los 25 estudiantes del curso de Ciencias Naturales. 
            //Por cada estudiante se debe calcular su nota definitiva y determinar si aprobó o reprobó.
            //Utilizando obligatoriamente una estructura repetitiva, el programa debe:
            //Solicitar por teclado las tres calificaciones del período(Examen 1, Examen 2 y Trabajo de Investigación)
            //para cada uno de los 25 estudiantes.Cada nota debe estar entre 0.0 y 5.0.
            //Calcular el promedio de las tres notas y mostrar en pantalla si el estudiante Aprobó(promedio >= 3.5) o Reprobó.
            //Al finalizar el procesamiento de todo el curso, el programa debe mostrar un resumen estadístico que incluya:
            //La cantidad total de estudiantes que aprobaron.
            //La cantidad total de estudiantes que reprobaron.
            //El promedio general de todo el curso(el promedio de los promedios de los 25 estudiantes).

            float examen1;
            float examen2;
            float trabajoinvestigacion;

            float promedio=0;

            int contador = 1;

            float totalaprobado =0;
            float totalreprobado =0;
            float Acumulacionprom =0;

            Console.WriteLine("Bienvenido, a continuacion podra calcular su nota de la materia de ciencias naturales para ver si aprobo (promedio de 3,5 o más");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese notas de 0,0 a 5,0 porfavor (Hagalo usando la , PORFAVOR)");

            do
            {

                Console.WriteLine("----------------ingrese nota de examen 1----------------");

                examen1 = float.Parse(Console.ReadLine());

                Console.WriteLine("----------------ingrese nota de examen 2----------------");

                examen2 = float.Parse(Console.ReadLine());

                Console.WriteLine("----------------ingrese nota del trabajo de investigación----------------");

                trabajoinvestigacion = float.Parse(Console.ReadLine());

                promedio = (examen1 + examen2 + trabajoinvestigacion) / 3;

                Console.WriteLine($"Promedio de notas: {promedio}");

                if (promedio < 3.5)
                {
                    Console.WriteLine($"Su promedio fue de: {promedio}");

                    Console.WriteLine("Usted no logro aprobar el curso");

                    totalreprobado++;
                }

                if (promedio >= 3.5)
                {
                    Console.WriteLine($"Su promedio fue de: {promedio}");

                    Console.WriteLine("Usted logro aprobar el curso");

                    totalaprobado++;
                }

                Acumulacionprom += promedio;

                contador++;
                if (contador < 5)
                {
                Console.WriteLine("Siguiente estudiante");

                }


            } while (contador <= 5);
            Console.WriteLine("--------------------------------------------------");
            
            Acumulacionprom = Acumulacionprom / contador;

            Console.WriteLine($"Total de estudiantes aprobados: {totalaprobado}");
            Console.WriteLine($"Total de estudiantes reprobados: {totalreprobado}");
            Console.WriteLine($"Promedio del curso: {Acumulacionprom}");


        }
    }
}
