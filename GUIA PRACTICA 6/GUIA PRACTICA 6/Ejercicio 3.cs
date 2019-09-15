using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_6
{
    class Ejercicio_3
    {

        private static void Expo(double numBase = 0, double elevado = 0, double numExponente = 0)
        {
            if (numBase == 0)
            {
                Console.WriteLine();
                Console.WriteLine("CERO ELEVADO A CUALQUIER NUMERO, SIEMPRE SERA CERO");
            }
            else
            {
                if (numBase > 1)
                {
                    elevado = Math.Pow(numBase, numExponente);
                    Console.WriteLine();
                    Console.WriteLine(string.Format("EL RESULTADO DE: " + numBase + " ELEVADO Al EXPONENTE " + numExponente + " ES DE: " + elevado));
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            int numBase = 0, numExponente = 0;
            double elevado = 0;
            Console.WriteLine("ESCRIBE UN NUMERO ENTERO");
            numBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("ESCRIBE EL EXPONENTE A ELEVAR");
            numExponente = Convert.ToInt32(Console.ReadLine());
            Expo(numBase, elevado, numExponente);
            Console.ReadKey();
        }
    }   
}
