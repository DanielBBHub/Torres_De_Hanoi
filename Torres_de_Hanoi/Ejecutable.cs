using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hanoi juego = new Hanoi();
            juego.ejecutarHanoi();
        }
    }
}
