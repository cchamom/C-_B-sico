﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Numero entero: ");
            try
            {

                int numeroEntero = int.Parse(Console.ReadLine());

                if (numeroEntero == 7)
                    Console.WriteLine("numeroEntero es 7.");
                else if (numeroEntero < 0)
                    Console.WriteLine("numeroEntero es Negativo");
                else
                {
                    Console.WriteLine("numeroEntero no es ninguno de los casos programados");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: No ha ingresado entero Valido");
            }
            Console.ReadLine();
        }
    }
}