using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int, string> Kullanici = new MyDictionary<int, string>();
            Kullanici.Add(100, "Mihriban Karakılıç");
            Kullanici.Add(140, "Asya Mira Karakılıç");
            Kullanici.Add(250, "Arif Doğan Karakılıç");
            Kullanici.Add(524, "Simay Karakılıç");

            Console.WriteLine(Kullanici.Lenght);

            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < Kullanici.Lenght; i++)
            {
                Console.WriteLine(Kullanici.Keys[i]+" "+Kullanici.Values[i]);

            }
            Console.Read();
        }
    }
}