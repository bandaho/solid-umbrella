using System;

namespace TerePimedus
{
    internal class Tervitaja
    {
        // kuvab ekraanile tervitus teksti
        internal static void Tervita(string who)
        {
            Console.WriteLine("Hello {0}.", who);
        }

        internal static void Tervita(string[] v)
        {
            Console.WriteLine("Hello {0}.", v);
            Console.WriteLine("Hello {1}.", v);
            Console.WriteLine("Hello {2}.", v);
        }
    }
}