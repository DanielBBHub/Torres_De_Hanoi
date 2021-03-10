using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        //El {get; set;} hace a la variable una propiedad auto-implementada y establece la
        //manera en la que se puede acceder a ella
        int tamanyo { get; set; }
        String color { get; set; }

        public Disco()
        {

        }

        //Dos constructores por si se quiere crear un disco solo con tamaño
        public Disco(int primerTamanyo)
        {
            tamanyo = primerTamanyo;
        }

        //o tambien con color, aun que este ultimo no va a ser crucial en el funcionamiento
        public Disco(int primerTamanyo, String primerColor)
        {
            tamanyo = primerTamanyo;
            color = primerColor;
        }

    }
}
