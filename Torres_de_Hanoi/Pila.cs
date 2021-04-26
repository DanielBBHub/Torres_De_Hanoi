using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /*TODO: Implementar métodos */

        //El {get; set;} hace a la variable una propiedad auto-implementada y establece la
        //manera en la que se puede acceder a ella (si es solo de lectura {get;}, si se puede modificar incluimos el set)
        int numDiscos { get; set; }
        int ultimoDisco { get; set; }
        List<Disco> listaDiscos = new List<Disco>();
        String nombrePila = "";


        public Pila(String nombre)
        {
            numDiscos = 0;
            nombrePila = nombre;
        }

        public void push(Disco d)
        {
            listaDiscos.Add(d);
            Console.WriteLine("Metiendo en: " + nombrePila + "\n");
            ultimoDisco = d.getTamanyo();
            numDiscos++;

        }

        public Disco pop()
        {
            if (!isEmpty())
            {
                numDiscos--;
                Disco discoSacado = new Disco();
                discoSacado = listaDiscos[listaDiscos.Count - 1];
                Console.WriteLine("Moviendo desde: " + nombrePila);
                Console.WriteLine("Muevo disco: " + discoSacado.getTamanyo());
                listaDiscos.RemoveAt(listaDiscos.Count - 1);
                if (listaDiscos.Count != 0)
                {
                    ultimoDisco = listaDiscos[listaDiscos.Count - 1].getTamanyo();
                }
                return discoSacado;
            }
            else
            {
                return null;
            }
        }                

        public bool isEmpty()
        {
            if (numDiscos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getUltimoDisco()
        {
            return ultimoDisco;
        }

        public int getNumDiscos()
        {
            return numDiscos;
        }
    }
}
