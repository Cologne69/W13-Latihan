using System;
using System.Linq;

namespace W13_Latihan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input Kalimat : ");
            string inputKalimat = Console.ReadLine();
            while (inputKalimat.Length < 3)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                Console.Write("Input Kalimat : ");
                inputKalimat = Console.ReadLine();


            }


            Console.Write("Input Kata : ");
            string inputKata = Console.ReadLine();

            foreach (char Kata in inputKalimat)
            {
                Console.WriteLine("Statistic Huruf: \n");

            }
            
            string test = inputKata.ToCharArray();
            int brpKali = inputKalimat.Count(f => (f == inputKata));
            Console.WriteLine(brpKali);
        }
    }
}
