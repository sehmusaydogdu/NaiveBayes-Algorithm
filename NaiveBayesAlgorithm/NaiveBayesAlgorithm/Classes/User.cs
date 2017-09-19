using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesAlgorithm.Classes
{
    class User
    {
        public static char _dogum, _sudaYasam, _ucma, _bacakSahip;
        public static void kullaniciDegerlerGir()
        {
            Console.WriteLine("Doğum sınıfının değerini giriniz <E / H> ");
             _dogum = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Uçma sınıfının değerini giriniz <E / H> ");
            _ucma = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Suda Yaşam sınıfının değerini giriniz <E / H / B> ");
            _sudaYasam = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Bacaklara sahip sınıfının değerini giriniz <E / H> ");
             _bacakSahip = Convert.ToChar(Console.ReadLine().ToUpper());
        }
    }
}
