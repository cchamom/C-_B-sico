﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_Teclado
{
    /// <summary>
    /// Leer datos desde teclado
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de dos números");
            Console.WriteLine("Ingresa número 1: ");
            //Los datos se leen como cadena 
            string dato = Console.ReadLine();
            //Convertir a número con int.Parse
            int n1 = int.Parse(dato);

            Console.WriteLine("Ingresa número 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El Resultado es:  {0}", suma);
            Console.ReadLine();

        }
    }
}
