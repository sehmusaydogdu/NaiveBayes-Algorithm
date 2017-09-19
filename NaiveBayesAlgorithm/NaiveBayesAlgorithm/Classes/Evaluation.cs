using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesAlgorithm.Classes
{
    class Evaluation
    {
        public static double memeliDegeri,memeliOlmayanDeger;

        private static double dogumSay,ucmaSay,sudaYasamSay,bacakSahipSay;
        private static void @default()
        {
            dogumSay = 0;
            ucmaSay = 0;
            sudaYasamSay = 0;
            bacakSahipSay = 0;
        }
        public static void karsilastir()
        {
            Console.WriteLine();
            Evaluation.@default();
            for (int i = 0; i < Data.sinif.Length; i++)
            {
                if (Data.dogum[i] == User._dogum && Data.sinif[i] == 'M') dogumSay++;
                if (Data.ucma[i] == User._ucma && Data.sinif[i] == 'M') ucmaSay++;
                if (Data.sudaYasam[i] == User._sudaYasam && Data.sinif[i] == 'M') sudaYasamSay++;
                if (Data.bacakSahip[i] == User._bacakSahip && Data.sinif[i] == 'M') bacakSahipSay++;
            }
            memeliDegeri = dogumSay / Data.memeli * ucmaSay / Data.memeli * sudaYasamSay / Data.memeli * bacakSahipSay / Data.memeli * Data.memeli / Data.sinif.Length;
            Console.WriteLine($"<<  Memeli  >> Grubuna ait olma olasılığı : {memeliDegeri}  ");
            Evaluation.@default();
            for (int i = 0; i < Data.sinif.Length; i++)
            {
                if (Data.dogum[i] == User._dogum && Data.sinif[i] == 'D') dogumSay++;
                if (Data.ucma[i] == User._ucma && Data.sinif[i] == 'D') ucmaSay++;
                if (Data.sudaYasam[i] == User._sudaYasam && Data.sinif[i] == 'D') sudaYasamSay++;
                if (Data.bacakSahip[i] == User._bacakSahip && Data.sinif[i] == 'D') bacakSahipSay++;
            }
            memeliOlmayanDeger = dogumSay / Data.memelidegil * ucmaSay / Data.memelidegil * sudaYasamSay / Data.memelidegil * bacakSahipSay / Data.memelidegil * Data.memelidegil / Data.sinif.Length;
            Console.WriteLine($"<<  Memeli Olmayan  >> Gruba ait olma olasılığı : {memeliOlmayanDeger}  ");

            Console.WriteLine();
            if (memeliDegeri>memeliOlmayanDeger)
                Console.WriteLine("Girilen özelliklere göre Memeli grubuna aittir !!!");
            else
                Console.WriteLine("Girilen özelliklere göre Memeli Olmayan grubuna aittir !!!");

        }
    }
}
