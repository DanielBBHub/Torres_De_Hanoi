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
        int numMovimientos = 0;
        Pila pilaINI = new Pila();
        Pila pilaAUX = new Pila();
        Pila pilaFIN = new Pila();

        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            Disco discoAux = new Disco();
            if(comprobarMovimiento(a, b).Equals("A"))
            {
                discoAux = a.pop();
                b.push(discoAux);
            }
            else
            {
                discoAux = b.pop();
                a.push(discoAux);
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            asignarDiscosPilaIni(generarDiscos(n));
            if(n%2 == 0)
            {
                do
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
                while (fin.getNumDiscos() == 3);
            }

            if (n % 2 != 0)
            {
                do
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
                while (fin.getNumDiscos() == 3);
            }


            return 0;
        }

        //Comprobar el ultimoDisco de cada una de las pilas y si el movimiento a->b es posible segun las reglas
        //o si por el contrario el movimiento correcto es b->a
        public String comprobarMovimiento(Pila a, Pila b)
        {
            if (a.isEmpty())
            {
                return "B";
            }
            else if (b.isEmpty()) {
                return "A";
            }

            if(a.getUltimoDisco() > b.getUltimoDisco())
            {
                return "B";
            }
            else
            {
                return "A";
            }

        }

        //Funcion para generar dinamicamente la cantidad de discos
        //que se desee
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

        //Como todas las veces que se comiece el juego van a estar todos
        //los discos en la pilaINI creo un metodo para asignarlos dinamicamente
        public void asignarDiscosPilaIni(List<Disco> totalDiscos)
        {
            for (int i = 0; i < totalDiscos.Count; i++)
            {
                pilaINI.push(totalDiscos[i]);
            }
        }
    }
}
