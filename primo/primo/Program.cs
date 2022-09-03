using System;

namespace primo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("=               bienvenido         =");
            Console.WriteLine("=====================================");
            Console.WriteLine("hola input: ");
            int jaj = Int32.Parse(Console.ReadLine());
            if (jaj < 0)
            {
                Console.Write("mal joven");
            }
            else
            {
                int numero = jaj /1;
                int numero2 = jaj / jaj;
                if (numero == jaj|| numero2==0)
                {
                    Console.Write("primo");

                }
                else {if (numero == 1) { Console.Write("no primo"); } }
            }
        }
    }
}
