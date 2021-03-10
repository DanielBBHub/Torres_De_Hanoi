using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int n = 3;
        Pila pilaINI = new Pila();
        Pila pilaAUX = new Pila();
        Pila pilaFIN = new Pila();

        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            List<Disco> totalDiscos = new List<Disco>();
            totalDiscos=generarDiscos(n);



            return 0;
        }

        //Comprobar el ultimoDisco de cada una de las pilas y si el movimiento a->b es posible segun las reglas
        //o si por el contrario el movimiento correcto es b->a
        public int comprobarMovimiento(Pila a, Pila b)
        {
            return 0;

            return 1;
        }

        public List<Disco> generarDiscos(int numDiscos)
        {
            List<Disco> discos = new List<Disco>();

            for(int i = 0; i<=n; i++)
            {
                Disco disco = new Disco(i);
                discos.Add(disco);
            }

            return discos;
        }
    }
}
