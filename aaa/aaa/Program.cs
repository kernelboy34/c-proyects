using System;

namespace aaa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("++++++BIENVENIDO++++++++");
            Console.WriteLine("incresa tu longitud de frase=");
            string j = Console.ReadLine();
            int h = Int32.Parse(j);
            Console.WriteLine("incresa tu frase =");
            string g = Console.ReadLine();
            if  (h   == g.Length )
            {


                if (g[0]== 'h'|| g[1]=='m'||g[2]=='z'||g[3]=='w')
                {

                    Console.WriteLine("es consonante");




                }


            }

        }
    }
}
