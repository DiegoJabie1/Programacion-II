using System;
using System.Collections.Generic;
using System.Text;
using Clase06_Entidades;

namespace Clase_06_Entidades
{
    class Paletas
    {
        private Temperas[] colores;
        private int cantidadMaximaColores;

        public Paletas() : this(5)
        {
        }

        public Paletas(int num)
        {
            this.colores = new Temperas[num];
            this.cantidadMaximaColores = num;
        }

        public static implicit operator Paletas(int num)
        {
            return new Paletas(num);
        }

        private string Mostrar()
        {
            string retorno = "Cantidad maxima colores: " + this.cantidadMaximaColores.ToString() + "\n";

            foreach (Temperas colores in this.colores)
            {
                retorno += (string)colores+"\n";
            }

            return retorno;
        }

        public static bool operator ==(Paletas paleta, Temperas tempera)
        {
            bool retorno = false;
            foreach(Temperas actual in paleta.colores)
            {
                if (actual == tempera)
                {
                    retorno = true;
                }
            }
        
                
        return retorno;        
        }
       
        public static bool operator !=(Paletas paleta, Temperas tempera)
        {
            return !(paleta == tempera);
        }

        private int ObtenerLugarLibre()
        {
            int index = -1;

            for (int i=0; i < this.colores.Length; i++)
            {
                if (this.colores[i] == null)
                {
                    index = i;

                    break;
                }

            }
            return index;
        }

        public static Paletas operator +(Paletas paleta, Temperas tempera)
        {
            if (paleta == tempera)
            {
                int index;
                index = Array.IndexOf(paleta.colores, tempera);

                paleta.colores[index] = paleta.colores[index] + tempera;
            }

            else if(paleta.ObtenerLugarLibre()!= -1)
            {
                int index = paleta.ObtenerLugarLibre();

                paleta.colores[index] = tempera;
            }

            return paleta;
        }

    }
}
