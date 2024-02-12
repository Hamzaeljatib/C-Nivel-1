using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            var culpable = window.prompt("¿eres culpable?"); // si, no

	if(culpable=="si"){
		Console.WriteLine("irás a la cárcel");
	}else if(culpable=="no"){
		Console.WriteLine("irás a casa");
	}else{
		Console.WriteLine("la documentación por favor");
	}
        }
    }
}
