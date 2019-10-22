using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES_22OCT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("elije una opción");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    arreglos.númerosAscendentes();
                    break;
                case 2:

                    arreglos.númerosDescendentes();
                    break;



            }
            Console.ReadKey();

        }

    }
}
