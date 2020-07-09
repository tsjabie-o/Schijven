using System;
using System.Collections.Generic;

namespace Opdracht_2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<long> standaardBlokken = new List<long>();
            long aantalStandaardBlokken = long.Parse(Console.ReadLine().Split(' ')[0]);
            for (int i = 0; i < aantalStandaardBlokken; i++)
            {
                long standaardBlok = long.Parse(Console.ReadLine().Split(' ')[0]);
                standaardBlokken.Add(standaardBlok);
            }
            List<long> steunBlokken = new List<long>();
            long aantalSteunBlokken = long.Parse(Console.ReadLine().Split(' ')[0]);
            for (int i = 0; i < aantalSteunBlokken; i++)
            {
                long steunBlok = long.Parse(Console.ReadLine().Split(' ')[0]);
                steunBlokken.Add(steunBlok);
            }

            long totalSchijfjes = 0;
            foreach (long steunBlok in steunBlokken)
            {
                long bestBlock = GetBestBlockSize(standaardBlokken, steunBlok);
                long aantalSchijfjes = GetAantalSchijfjes(bestBlock, steunBlok);
                totalSchijfjes += aantalSchijfjes;
            }
            Console.WriteLine(totalSchijfjes.ToString());
        }
        static long GetBestBlockSize(List<long> blocks, long x)
        {
            int i = 0;
            int j = blocks.Count - 1;

            if (blocks.Count == 0)
            {
                return 0;
            }

            while (j - i > 1)
            {
                int middle = (i + j) / 2;

                if (blocks[middle] > x)
                {
                    j = middle;
                }
                else
                {
                    i = middle;
                }
            }

            if (blocks[j] > x)
            {
                if (blocks[i] > x)
                {
                    return 0;
                }
                return blocks[i];
            }
            return blocks[j];
        }

        static long GetAantalSchijfjes(long blok, long x)
        {
            return x - blok;
        }
    }
}
