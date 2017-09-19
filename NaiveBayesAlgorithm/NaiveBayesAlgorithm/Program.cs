using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaiveBayesAlgorithm.Classes;

namespace NaiveBayesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.sinifSay();
            User.kullaniciDegerlerGir();
            Evaluation.karsilastir();
            Console.ReadKey();
        }
    }
}
