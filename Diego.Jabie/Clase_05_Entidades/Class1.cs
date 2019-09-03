using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private eTipoTinta _tipo;


        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = eTipoTinta.comun;
        }

        public Tinta(ConsoleColor _color) : this()
        {
            this._color = _color;
        }

        public Tinta(eTipoTinta _tipo, ConsoleColor _color) : this(_color)
        {
            this._tipo = _tipo;
        }

        private string Mostrar()
        {
            return this._color.ToString() + " " + this._tipo.ToString();

        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator == (Tinta tinta1, Tinta tinta2)
            {
            if (tinta1._color != tinta2._color || tinta1._tipo != tinta2._tipo)
            {
                return false;
            }
            else
            {
                return true;
            }
            }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1==tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            if (tinta._color == color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta._color == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }


    }

}
