using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public void mototCalistir()
        {
            Console.WriteLine("Motor çalışıyor...");
        }

        public void kapilarKilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor.");
        }
    }
}
