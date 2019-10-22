using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES_22OCT
{
    class arreglos
    {
        public static void númerosAscendentes()
        {
            Console.WriteLine("los números al 100 son: /n");
            int[] arreglo = new int[1];
            for (int i = 0; i < 100; i++)

                Console.WriteLine(i + 1);

        }

        public static void númerosDescendentes()
        {
            Console.WriteLine("los números del 100 al 1");
            int[] arreglo = new int[1];
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}