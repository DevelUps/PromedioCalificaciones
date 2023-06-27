using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PromedioCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Asignación compuesta (x -= 5) == (x = x - 5)
             // acumulador = acumulador + variable) == (acumulador += variable
             //variables

            byte i, numAlumnos;
            double  calificacion, sumaCalif = 0, promedio;

            Console.Write("Por favor ingresa el numero de alumnos:  ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for(i = 0; i < numAlumnos; i++) 
            {
                Console.Write("Por favor ingresa la calificacion:  ");
                calificacion = Convert.ToDouble(Console.ReadLine());

               sumaCalif += calificacion;
            }
            promedio = sumaCalif / numAlumnos;
            Console.WriteLine("El promedio del curso es {0}",promedio);





        }
    }
}
