﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
           

            if (a == 11)
            {

                Console.WriteLine("Sao Paulo");
            }
            else if  (a == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if ( a == 71)
            {
                Console.WriteLine("Salvador");

            }
            else if (a == 21)
            {
                Console.WriteLine("Rio de Janeiro");

            }
            else if ( a == 32)
            {
                Console.WriteLine("Juiz de Fora");

            }
            else if (a == 19)
            {
                Console.WriteLine("Campinas");

            }
            else if (a == 27 )
            {
                Console.WriteLine("Vitoria");
            }
            else if ( a == 31)
            {
                Console.WriteLine("Belo Horizonte");

            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            Console.ReadKey();
        }   
    }
}
