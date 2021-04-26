using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        int n = 5;
        int numMovimientos = 0;

        Pila pilaINI = new Pila("Ini");
        Pila pilaFIN = new Pila("Fin");
        Pila pilaAUX = new Pila("Aux");

        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            Disco discoAux = new Disco();
            if (pilaFIN.getNumDiscos() != n || pilaAUX.getNumDiscos() != n)
            {
                if(comprobarMovimiento(a, b).Equals("C"))
                {
                    return;
                }
                if (comprobarMovimiento(a, b).Equals("A"))
                {
                    discoAux = a.pop();
                    b.push(discoAux);
                    numMovimientos++;
                }
                else
                {
                    discoAux = b.pop();
                    a.push(discoAux);
                    numMovimientos++;
                }
            }

        }

        public void iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            generarDiscos(n);
            if(n%2 != 0)
            {
                do
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }
                
               while( fin.getNumDiscos() != n);
               Console.WriteLine("Número de movimientos totales = " + numMovimientos.ToString());
               Console.ReadLine();
            }

            if (n % 2 == 0)
            {
                do
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
                while (fin.getNumDiscos() != n);
                Console.WriteLine("Número de movimientos totales = " + numMovimientos.ToString());
                Console.ReadLine();
            }



        }

        //Comprobar el ultimoDisco de cada una de las pilas y si el movimiento a->b es posible segun las reglas
        //o si por el contrario el movimiento correcto es b->a
        public String comprobarMovimiento(Pila a, Pila b)
        {
            if (pilaFIN.getNumDiscos() != n)
            {


                if (a.isEmpty())
                {
                    return "B";
                }
                else if (b.isEmpty())
                {
                    return "A";
                }

                if (a.getUltimoDisco() > b.getUltimoDisco())
                {
                    return "B";
                }
                else
                {
                    return "A";
                }
            }
            else
            {
                return "C";
            }

        }

        //Funcion para generar dinamicamente la cantidad de discos
        //que se desee
        public void generarDiscos(int numDiscos)
        {
            List<Disco> discos = new List<Disco>();

            for(int i = n; i>=1; i--)
            {
                Disco disco = new Disco(i);
                Console.WriteLine(disco.getTamanyo());
                discos.Add(disco);

            }
            for(int i = 0; i< discos.Count; i++)
            {
                asignarDiscosPilaIni(discos[i]);

            }
        }

        //Como todas las veces que se comiece el juego van a estar todos
        //los discos en la pilaINI creo un metodo para asignarlos dinamicamente
        public void asignarDiscosPilaIni(Disco disco)
        {
            pilaINI.push(disco);
        }

        public void ejecutarHanoi()
        {
            iterativo( n,  pilaINI,  pilaFIN,  pilaAUX);
        }
    }
}
