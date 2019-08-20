using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max=0;
            int min=0;
            int acumNum=0;
            float promedio;
            int i;
            Console.WriteLine("Ingrese 5 numeros: ");

            for (i = 0; i < 5; i++)
            {
                Console.Write("Numero {0}:", i + 1);

                num = int.Parse(Console.ReadLine());

                acumNum = acumNum + num;

                if(i == 0)
                {
                    max = num;
                    min = num;
                }
                else if (max < num)
                {
                    max = num;
                }
                else if (min > num)
                {
                    min = num;
                }
            }

            promedio = (Single)acumNum / i;

            Console.WriteLine("El máximo es {0}, el mínimo es {1}, el promedio es {2}, y el total es {3}",max,min,promedio,acumNum);

            Console.ReadLine();


        }
    }
}
