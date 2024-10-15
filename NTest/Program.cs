using System;
using System.Threading;

namespace NTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = "o";
            bool Wooloolo = true;


            //oppgave:
            //få dette til å gå evig. ved å bruke en eller annen loop. foreach, while, for


            //loop legger til tegn
            while (true)
            {
                Console.WriteLine(symbol);
                //manipulere symbolet for hver runde
                if (Wooloolo)
                {
                    symbol = symbol + "o";

                    if (symbol.Length == 9)
                    {
                        Wooloolo = false;
                    }

                }


                //fjerner tegn
                else
                {
                    symbol = symbol.Remove(symbol.Length - 1, 1);

                    if (symbol.Length == 1)

                    {

                        Wooloolo = true;

                    }

                }

                Thread.Sleep(100);

            }

        }
    }
}
