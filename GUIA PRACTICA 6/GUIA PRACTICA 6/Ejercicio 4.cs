using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_6
{
    class Ejercicio_4
    {
        static void Binario(int bin)

        {
            if (bin != 0)
            {
                Binario(bin / 2);
                Console.WriteLine("\t" + bin % 2);
            }
        }
        public static int Main()

        {
            int num;
            Console.WriteLine("CONVERSION DECIMAL A CODIGO BINARIO");
            Console.WriteLine();
            Console.WriteLine("\nINTRODUCE UN NUMERO ENTERO PARA CONVERTIR");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("+========================================================+");
            Console.WriteLine("+      ESTA ES LA CONVERCION BINARIA DE EL NUMERO " + num + "     +");
            Console.WriteLine("+========================================================+");
            Binario(num);
            return 0;
        }
    }
}
