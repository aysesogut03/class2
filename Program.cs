using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Program
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba();
            araba1.arabaModel = "Renault";
            araba1.arabaRengi = "Kırmızı";
            araba1.kapiSayisi = 4;
            araba1.kapilarKilitle();
            araba1.mototCalistir();

            Console.WriteLine("***********");
            Console.WriteLine("Araba modeli:" + araba1.arabaModel);
            Console.WriteLine("Araba rengi:" + araba1.arabaRengi);
            Console.WriteLine("Kapı sayısı:" + araba1.kapiSayisi);
            Console.ReadLine();
        }
    }
}
