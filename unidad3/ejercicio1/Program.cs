﻿using System;

namespace ejercicio1
{
    class Program
    {

        //Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.    

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            if (n > 10){
                Console.WriteLine("El numero es mayor a 10");

            }else{
                Console.WriteLine("El número no es mayor que 10");
            }

        }
    }
}
