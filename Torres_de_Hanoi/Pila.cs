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
        List<Disco> listaDiscos { get; set; }


        public Pila()
        {
            numDiscos = 0;
        }

        public void push(Disco d)
        {
            listaDiscos.Add(d);
            numDiscos++;
            ultimoDisco = d.getTamanyo();
        }

        public Disco pop()
        {
            if (!isEmpty())
            {
                Disco discoSacado = new Disco();
                discoSacado = listaDiscos[listaDiscos.Count - 1];
                listaDiscos.RemoveAt(listaDiscos.Count - 1);
                numDiscos--;
                ultimoDisco = listaDiscos[listaDiscos.Count - 1].getTamanyo();
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

    }
}
