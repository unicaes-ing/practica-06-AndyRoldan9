using System;

namespace GUIA_PRACTICA_6
{
    class Program
    {
        public static  void Tabla(int n)
        {

            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine( n +" x " + i + " = " +i*n);         
            }            
        }
        public static void Tabla(int n, ConsoleColor colortexto)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.ForegroundColor = colortexto;
                Console.WriteLine(n + " x " + i + " = " + i * n);               
            }
        }
        static void Main(string[] args)
        {
            int n;            
                Console.WriteLine("TABLAS DE MULTIPLICAR");
                Console.WriteLine();
                Console.WriteLine("INGRESA EL NUMERO DE LA TABLA QUE DESEAS VER");
                n = int.Parse(Console.ReadLine());
                Tabla(n);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("TABLAS DE MULTIPLICAR");
                Console.WriteLine();
                Console.WriteLine("INGRESA EL NUMERO DE LA TABLA QUE DESEAS VER");
                n = int.Parse(Console.ReadLine());
                Tabla(n, ConsoleColor.Green);           
                Console.ReadKey();            
        }
}   } 
