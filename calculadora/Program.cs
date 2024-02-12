using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        { 
           //paso 0: 
           //tipo de dato: int(entero) / float(numeros con ,) / char(letras) / bool(true,false)

            int n1, n2, resultado;
            
            //CAMBIO DE EJEMPLO GITHUB

        //    //paso 1: pedir valores

           Console.WriteLine("Ingrese un numero:");
           n1 = int.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese otro:");
           n2 = int.Parse(Console.ReadLine());

        //    //paso 2: realizar calculos

           resultado = n1 + n2;


        //    //paso 3: emitir resultado

            Console.WriteLine("El resultado es: " + resultado);



       

        }
    }
}
