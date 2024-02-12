using System;

            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
            // más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y que 
            // luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.


            // Sueldo fijo de 15000 ARS
            // Comision del 5% sobre el total facturado



namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float tf, comision, sf;

            Console.WriteLine("Ingrese el Total Facturado");

            tf = float.Parse(Console.ReadLine());

            comision = 0.05f * tf;

            sf = comision + 15000;

            Console.WriteLine("El suedo final es: " + sf);

        }
    }
}



// OTRA OPCION

// Esto sirve para cambiar todos los valores
// de una sola vez, los guardo en una VARIABLE


// namespace ejercicio4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float tf, comision, sf;
//             float sf = 15000;
//             float comision = 0.05f;

//             Console.WriteLine("Ingrese el Total Facturado");

//             tf = float.Parse(Console.ReadLine());

//             comision = comision * tf;

//             sf = comision + sf;

//             Console.WriteLine("El suedo final es: " + sf);

//         }
//     }
// }












