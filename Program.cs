using System;

namespace AsiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool asilama = false;
            bool bagisiklik = false;
            bool riskgrubu = false;
            int asi = 0;

           DateTime tarih = DateTime.Now;
           DateTime tarihSubat = new DateTime(2021, 2, 1);
           DateTime tarihMart = new DateTime(2021, 3, 1);
           DateTime onBesMart = new DateTime(2021,3,15);

           if ((tarih <= tarihMart && asi == 5000000 && asilama == true) && (tarih <= onBesMart && bagisiklik == true && riskgrubu == true))
                Console.WriteLine("Çok belirgin rahatladık :)");
           else
                Console.WriteLine("Çok belirgin ...:( ");
            Console.ReadLine();
        }
    }
}