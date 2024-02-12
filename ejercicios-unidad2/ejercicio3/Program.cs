using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros , velocidad , tiempo;

            Console.WriteLine("Ingrese las distancia entre ciudad y ciudad en KM");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad del vehiculo");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = kilometros / velocidad;

            Console.WriteLine("El tiempo estimado de viaje es:" + tiempo + " horas...");


        }
    }
}
