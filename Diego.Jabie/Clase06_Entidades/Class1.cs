using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase06_Entidades
{
    public class Temperas
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Temperas(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;

        }

        private string Mostrar()
        {
            return this.color.ToString() + " " + this.marca.ToString() + " " + this.cantidad.ToString();
        }

        public static implicit operator string(Temperas tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Temperas tempera1, Temperas tempera2)
        {
            bool retorno = false;

            if (Object.Equals(tempera1, null) == false && Object.Equals(tempera2, null) == false)
            {
                if (tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
                {
                    retorno = true;
                }
     
            }
            return retorno;
        }

        public static bool operator !=(Temperas tempera1,Temperas tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static Temperas operator +(Temperas tempera, int num)
        {
            if (Object.Equals(tempera, null) == false)
            {
                tempera.cantidad = tempera.cantidad + num;
            }
            return tempera;
        }

        public static Temperas operator +(Temperas tempera1, Temperas tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1 += tempera2.cantidad;
            }

            return tempera1;
        }
    }
}
