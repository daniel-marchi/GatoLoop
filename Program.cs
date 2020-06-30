using System;

namespace GatoLoop
{
    class Program
    {
        //Quando excutar 'dotnet run'
        static void Main(string[] args)
        {
            var gato = new Gato();

            for (var contador = 1; contador <= 10; contador++)
            {
                gato.ProximaFantasia();
                gato.Mova10passos();

                Console.WriteLine($"***Rodou {contador} vez\r\n");

                gato.Esperar(2000);
            }

            gato.Miar();
        }

    }
}
