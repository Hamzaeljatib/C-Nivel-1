using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

            float importe;
            float descuento1 = 0.90f;
            float descuento2 = 0.82f;

            Console.WriteLine("Ingrese el importe de la compra");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 1000){

                if(importe >= 5000)
                    importe = importe * descuento2;
                else
                    importe = importe * descuento1;
            }

            Console.WriteLine("El valor a pagar es: " + importe);        

        }
    }
}

        // COMO LO QUISE HACER YO


        //          if (importe < 1000)
        //                 importeF = importe;

        //             if(importe >= 1000){  
                        
        //                 importeF = importe * descuento1;

                        
        //             }
        //             else if (importe >= 5000){
                        
        //                 importeF = importe * descuento2;    

        //             }
        //                 Console.WriteLine("El importe total a pagar es: " + importeF);
