using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, notaFinal;
            
            Console.WriteLine("Ingrese la Primera Nota");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Segunda Nota");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Tercera Nota");
            n3 = float.Parse(Console.ReadLine());

            notaFinal = (n1 + n2 + n3) / 3;

            Console.WriteLine("La Nota final es: " + notaFinal);

        }
    }
}
