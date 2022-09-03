using System;


namespace mydrugsproyecto
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+       bienvenido a mydrugs                         +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("antes de ingresar te pediremos tu clave  para entrar a la tienda");
            Console.WriteLine("        ");
            Console.WriteLine("        ");
            Console.Write("incresa tu clave: ");
            string clave, lectura;
            clave = "amo my drugs";
            lectura = Console.ReadLine();
            if (lectura == clave)
            {
                Console.WriteLine("        ");
                Console.WriteLine("        ");
                Console.WriteLine("bien hecho ahora sabemos que eres cliente de la tienda");
                Console.WriteLine("        ");
                Console.WriteLine("que tipo de producto quieres?");
                Console.WriteLine("a)canabinoides b)extasis  c)drogas sinteticas d)lsd e)metanfetamina");
                Console.WriteLine("        ");
                Console.Write("que escogiste?: ");
                string elecion = Console.ReadLine();
                if (elecion == "a" || elecion == "canabinoides" || elecion == "b" || elecion == "extasis" || elecion == "c" || elecion == "drogas sinteticas"||elecion=="d"||elecion=="e")
                {
                    switch (elecion)
                    {
                        case "a":
                            Console.WriteLine("existen muchos tipos de canabinoides que quieres?");
                            Console.WriteLine("a) purple kush ");
                            Console.WriteLine("b)mago kush");
                            Console.WriteLine("c)limon kush");
                            Console.WriteLine("d) hashies");
                            Console.WriteLine("        ");
                            Console.Write("que quieres?: ");
                            string elecion2 = Console.ReadLine();
                            if (elecion2 == "a" || elecion2 == "b" || elecion2 == "c" || elecion2 == "d")
                            {
                                Console.WriteLine("muy bien antes de empezar con la culminacion de la compra deberias revisar nuestro catalogo por la web");
                                Console.WriteLine("        ");
                                Console.Write("quieres?:");
                                string elecion3 = Console.ReadLine();
                                switch (elecion3)
                                {
                                    case "si":
                                        Console.Write("https://kernelboy34.github.io/_mydrugss/shop.html");
                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listo = Console.ReadLine();
                                        if (listo == "estoy listo")
                                        {
                                            switch (elecion2)
                                            {
                                                case "a":
                                                    Console.WriteLine("purple kush 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("mango kush 90 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }
                                        }
                                        break;
                                    case "no":

                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listoa = Console.ReadLine();
                                        if (listoa == "estoy listo")
                                        {
                                            switch (elecion2)
                                            {
                                                case "a":
                                                    Console.WriteLine("purple kush 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("mango kush 90 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }

                                        }
                                        break;

                                }







                            }
                            break;
                        case "b":
                            Console.WriteLine("existen muchos tipos de extasis que quieres?");
                            Console.WriteLine("a) mmda pastilla");
                            Console.WriteLine("b)mmda dosis jeringa");
                            Console.WriteLine("c)mmda purple explotion");
                            Console.WriteLine("d) lsd");
                            Console.WriteLine("        ");
                            Console.Write("que quieres?: ");
                            string elecionh = Console.ReadLine();
                            if (elecionh == "a" || elecionh== "b" || elecionh== "c" || elecionh == "d")
                            {
                                Console.WriteLine("muy bien antes de empezar con la culminacion de la compra deberias revisar nuestro catalogo por la web");
                                Console.WriteLine("        ");
                                Console.Write("quieres?:");
                                string elecion3 = Console.ReadLine();
                                switch (elecion3)
                                {
                                    case "si":
                                        Console.Write("https://kernelboy34.github.io/_mydrugss/shop.html");
                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listo = Console.ReadLine();
                                        if (listo == "estoy listo")
                                        {
                                            switch (elecionh)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }
                                        }
                                        break;
                                    case "no":

                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listoa = Console.ReadLine();
                                        if (listoa == "estoy listo")
                                        {
                                            switch (elecionh)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;





                                            }

                                        }
                                        break;

                                }







                            }
                            break;
                        case "c":
                            Console.WriteLine("existen muchos tipos de drogas sintesticas que quieres?");
                            Console.WriteLine("a) space (marihuana artificial)");
                            Console.WriteLine("b)dulses con space");
                            Console.WriteLine("c) honey moon");
                            Console.WriteLine("d) skitllez");
                            Console.WriteLine("        ");
                            Console.Write("que quieres?: ");
                            string elecionk = Console.ReadLine();
                            if (elecionk == "a" || elecionk == "b" || elecionk == "c" || elecionk == "d")
                            {
                                Console.WriteLine("muy bien antes de empezar con la culminacion de la compra deberias revisar nuestro catalogo por la web");
                                Console.WriteLine("        ");
                                Console.Write("quieres?:");
                                string elecion3 = Console.ReadLine();
                                switch (elecion3)
                                {
                                    case "si":
                                        Console.Write("https://kernelboy34.github.io/_mydrugss/shop.html");
                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listo = Console.ReadLine();
                                        if (listo == "estoy listo")
                                        {
                                            switch (elecionk)
                                            {
                                                case "a":
                                                    Console.WriteLine("space 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("dulses  120 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" honey moon 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine("skitillez 70 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }
                                        }
                                        break;
                                    case "no":

                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listoa = Console.ReadLine();
                                        if (listoa == "estoy listo")
                                        {
                                            switch (elecionk)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;





                                            }

                                        }
                                        break;

                                }







                            }
                            break;
                        case "d":
                            Console.WriteLine("existen muchos tipos de  que quieres?");
                            Console.WriteLine("a) mmda pastilla");
                            Console.WriteLine("b)mmda dosis jeringa");
                            Console.WriteLine("c)mmda purple explotion");
                            Console.WriteLine("d) lsd");
                            Console.WriteLine("        ");
                            Console.Write("que quieres?: ");
                            string elecionj = Console.ReadLine();
                            if (elecionj == "a" || elecionj == "b" || elecionj == "c" || elecionj== "d")
                            {
                                Console.WriteLine("muy bien antes de empezar con la culminacion de la compra deberias revisar nuestro catalogo por la web");
                                Console.WriteLine("        ");
                                Console.Write("quieres?:");
                                string elecion3 = Console.ReadLine();
                                switch (elecion3)
                                {
                                    case "si":
                                        Console.Write("https://kernelboy34.github.io/_mydrugss/shop.html");
                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listo = Console.ReadLine();
                                        if (listo == "estoy listo")
                                        {
                                            switch (elecionj)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }
                                        }
                                        break;
                                    case "no":

                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listoa = Console.ReadLine();
                                        if (listoa == "estoy listo")
                                        {
                                            switch (elecionj)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;





                                            }

                                        }
                                        break;

                                }







                            }
                            break;

                        case "e":
                            Console.WriteLine("existen muchos tipos de  que quieres?");
                            Console.WriteLine("a) mmda pastilla");
                            Console.WriteLine("b)mmda dosis jeringa");
                            Console.WriteLine("c)mmda purple explotion");
                            Console.WriteLine("d) lsd");
                            Console.WriteLine("        ");
                            Console.Write("que quieres?: ");
                            string eleciong = Console.ReadLine();
                            if (eleciong == "a" || eleciong == "b" || eleciong == "c" || eleciong == "d")
                            {
                                Console.WriteLine("muy bien antes de empezar con la culminacion de la compra deberias revisar nuestro catalogo por la web");
                                Console.WriteLine("        ");
                                Console.Write("quieres?:");
                                string elecion3 = Console.ReadLine();
                                switch (elecion3)
                                {
                                    case "si":
                                        Console.Write("https://kernelboy34.github.io/_mydrugss/shop.html");
                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listo = Console.ReadLine();
                                        if (listo == "estoy listo")
                                        {
                                            switch (eleciong)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;

                                            }
                                        }
                                        break;
                                    case "no":

                                        Console.WriteLine("        ");
                                        Console.Write("miralo mas a detalle");
                                        Console.WriteLine("cuando este listo escribe 'estoy listo' ");
                                        Console.Write("escribe aca: ");
                                        string listoa = Console.ReadLine();
                                        if (listoa == "estoy listo")
                                        {
                                            switch (eleciong)
                                            {
                                                case "a":
                                                    Console.WriteLine("mmda 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");

                                                    break;
                                                case "b":
                                                    Console.WriteLine("jeringa 190 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin2 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token2 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");


                                                    break;
                                                case "c":

                                                    Console.WriteLine(" purple explotion 150 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin3 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token3 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;
                                                case "d":
                                                    Console.WriteLine(" lsd 50 bs la dosis ");
                                                    Console.WriteLine("puedes pagar en nuestra web o aca https://kernelboy34.github.io/_mydrugss/pasarela.html");
                                                    Console.WriteLine("paga a aca tambie si lo deseas");
                                                    Console.Write("numero de cuenta de Criptocurrenci: ");
                                                    string bitcoin4 = Console.ReadLine();
                                                    Console.Write("token:");
                                                    string token4 = Console.ReadLine();
                                                    Console.Write("=="); Console.Write("======cargando======");
                                                    Console.Write("compra completada tu envio te llegara de 5 a 7 dias te mandaremos un mail de confirmacion por medio de protonmail");
                                                    break;





                                            }

                                        }
                                        break;

                                }







                            }
                            break;




                    }




                }
                
                else
                {
                    Console.WriteLine("hey estas intentado incresar sin autorizacion :c eso no es Bueno");
                }

            }
        }
    }
}
