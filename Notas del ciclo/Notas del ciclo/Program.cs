using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)

        {  //Prioridad de los operadores aritméticos.
            //ejercicio de obtener la nota final de la materia de Programacion I.
            Consola.Escribir(" Lab1 : ");​
            doble lab1 = doble.Parse(Console.ReadLine());  //8
            Consola.Escribir(" Lab2 : ");​
            doble lab2 = doble.Parse(Console.ReadLine());  //9
            Consola.Escribir(" Parcial 1: ");
            doble parcial1 = doble.Parse(Console.ReadLine());  //7
            // 8*30%= 2,4
            // 9*30%= 2,7
            // 7*40%= 2,8
            //C1 = 7,9

            doble c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Consola.WriteLine(" La nota de C1 es: {0} ", c1);

            Consola.Escribir(" Lab1 : ");​
            lab1 = double.Parse(Console.ReadLine());  //8

            Consola.Escribir(" Lab2 : ");​
            lab2 = double.Parse(Console.ReadLine());  //9

            Consola.Escribir(" Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());  //7

            doble c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Consola.WriteLine(" La nota de C2 es: {0} ", c2);

            //TAREA: Obtener la nota final por computo y Nota Final de la matera de Programacion I.


            //Pausa.
            Consola.ReadLine();​
        }

    }
}
