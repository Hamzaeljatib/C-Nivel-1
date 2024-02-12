using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            float a, b, c, d;

            Console.WriteLine("Ingrese un nro:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ultimo nro:");
            d = float.Parse(Console.ReadLine());

            if (a > 100)
                Console.WriteLine("El primer valor " + a + " es mayor a 100");

            if (b > 100)
                Console.WriteLine("El segundo valor " + b + " es mayor a 100");

            if (c > 100)
                Console.WriteLine("El tercer valor " + c + " es mayor a 100");

            if (d > 100)
                Console.WriteLine("El cuarto valor " + d + " es mayor a 100");
        }
    }
}
