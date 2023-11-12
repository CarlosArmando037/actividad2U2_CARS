
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjersiciosArreglos2_CARS.Clases
{
    internal class Ejercicios
    {
        //------------------------------------------------------------------------------------------ejercicio1
        
        int[] arreglo1 = new int[3];
        int[] arreglo2 = new int[3];
        int[] arregloresultado = new int[3];

        public void practica1()
        {
            for (int f=0;f<arreglo1.Length;f++)
            {
                Console.WriteLine("inserte el numero de arreglo 1:");
                arreglo1[f] = Convert.ToInt32(Console.ReadLine());
            
            }
            for (int f2=0; f2 < arreglo2.Length; f2++)
            {
                Console.WriteLine("inserte el numero de arreglo 2:");
                arreglo2[f2] = Convert.ToInt32(Console.ReadLine());
            }

            for (int f3=0;f3<arregloresultado.Length;f3++)
            {

                arregloresultado[f3] = arreglo1[f3] + arreglo2[f3];

                Console.WriteLine($"{arreglo1[f3]} + {arreglo2[f3]} = {arregloresultado[f3]}");

            }
        }
        
        //----------------------------------------------------------------------------------------------ejercicio2
        
        int[] arrayelementos = {1,2,3,4,5,6,2,4,1};
       
        public void practica2()
        {

            Console.WriteLine("inserte el numero que quiere buscar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());
            for (int f = 0; f < arrayelementos.Length; f++)
            {
                int posiciones = f;

                if (busqueda == arrayelementos[f])
                {
                    Console.WriteLine($"su busqueda esta en la posicion:{posiciones} del arreglo");
                }
                
            }
        }
        
        //-----------------------------------------------------------------------------------------------ejercicio3

        public void practica3()
        {
            int[] algebra = new int[5];
            int[] analisis = new int[5];
            int[] duales = new int[5];


            Console.WriteLine("Ingrese el ID de los 5 alumnos de Algebra");
            bool centinela = false;
            for (int i = 0; i < algebra.Length; i++)
            {

                algebra[i] = Convert.ToInt32(Console.ReadLine());


            }


            Console.WriteLine("Ingrese el ID de los 5 alumnos de clase análisis");

            for (int i = 0; i < analisis.Length; i++)
            {

                analisis[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i < analisis.Length; i++)
            {

                if (algebra[i] == analisis[i])
                {
                    duales[i] = algebra[i];

                    Console.WriteLine("Los alumnos que coinciden son los del ID " + duales[i] + " ");

                }

            }

        }
        //-----------------------------------------------------------------------------------------------ejercicio4

        public void practica4()
        {

            Console.WriteLine("Ingrese cual desea sea el tamaño de su arreglo Señor");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[tamaño];

            Console.WriteLine("Ingrese los numeros");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Los valores son " + string.Join(",", arreglo));
        }

        //-----------------------------------------------------------------------------------------------ejercicio5

        public void practica5()
        {

            Console.WriteLine("Ingrese cuantas notas son");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int[] arreglo = new int[tamaño];
            int[] arreglo2 = new int[tamaño];
            int promedio = 0;
            int deficientes = 0, regulares = 0, buenos = 0, excelentes = 0;
            Console.WriteLine("Ingrese las notas del 1 al 20");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0 && arreglo[i] <= 5)
                { deficientes++; }
                else if (arreglo[i] > 5 && arreglo[i] <= 10)
                    regulares++;
                else if (arreglo[i] > 10 && arreglo[i] <= 15)
                    buenos++;
                else if (arreglo[i] > 15 && arreglo[i] <= 20)
                    excelentes++;


            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                promedio += arreglo[i];
                total = promedio / tamaño;


            }

            Console.WriteLine("su promedio es de " + total);
            Console.WriteLine($"Su total de notas deficientes son {deficientes}, las Regulares {regulares}, las Buenas {buenos} y las Excelentes {excelentes}");

        }
    }
}
