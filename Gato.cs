using System;
using System.Threading;

namespace GatoLoop
{
    public class Gato
    {
        public void Miar()
        {
            Console.WriteLine("MEEEAAAAOUOUUUUU!!!!!");
        }
        public void ProximaFantasia()
        {
            Console.WriteLine("O Gato deu um passo!");
        }

        public void Mova10passos()
        {
            Console.WriteLine("O Gato andou!");
        }

        public void Esperar(int tempo)
        {
            //200 milisegundos é = a 0.2 segundos
            Thread.Sleep(tempo);
        }
    }
}
