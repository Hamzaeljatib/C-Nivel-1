using System;

namespace ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
             int n1, resu;

        Console.WriteLine("Ingrese el numero:");

        n1 = int.Parse(Console.ReadLine());

        resu = n1 * n1 * n1;

        Console.WriteLine("El resultado es: " + resu);
        
        }
    }
}
