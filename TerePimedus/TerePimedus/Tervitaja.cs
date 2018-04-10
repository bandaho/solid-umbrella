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

        internal static void Tervita(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Tervita(names[i]);
            }
        }
    }
}