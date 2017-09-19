using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesAlgorithm.Classes
{
    class Data
    {
        public static char[] dogum = { 'E', 'H', 'H', 'E', 'H', 'H', 'E', 'H', 'E', 'E', 'H', 'H', 'E', 'H', 'H', 'H', 'H', 'H', 'E', 'H' };
        public static char[] ucma = { 'H', 'H', 'H', 'H', 'H', 'H', 'E', 'E', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'H', 'E', 'H', 'E' };
        public static char[] sudaYasam = { 'H', 'H', 'E', 'E', 'B', 'H', 'H', 'H', 'H', 'E', 'B', 'B', 'H', 'E', 'B', 'H', 'H', 'H', 'E', 'H' };
        public static char[] bacakSahip = { 'E', 'H', 'H', 'H', 'E', 'E', 'E', 'E', 'E', 'H', 'E', 'E', 'E', 'H', 'E', 'E', 'E', 'E', 'H', 'E' };
        public static char[] sinif = { 'M', 'D', 'D', 'M', 'D', 'D', 'M', 'D', 'M', 'D', 'D', 'D', 'M', 'D', 'D', 'D', 'M', 'D', 'M', 'D' };

        public static double memeli = 0;
        public static double memelidegil = 0;

        public static void sinifSay()
        {
            for (int i = 0; i < sinif.Length; i++)
            {
                if (sinif[i] == 'M') memeli++;
                if (sinif[i] == 'D') memelidegil++;
            }
        }

    }
    
}
