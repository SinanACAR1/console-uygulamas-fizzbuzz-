using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("Fizz Buzz");  } //eğer i 3 ve 5'e tam bölünüyorsa bu işlemi yap.
                else if(i % 3 == 0) { Console.WriteLine("Buzz");  } //eğer sayi 3'e tam bölünüyorsa bu işlemi yap.
                else if(i % 5 == 0) { Console.WriteLine("Fizz");  } //eğer sayi 5'e tam bölünüyorsa  bu işlemi yap.
                else { Console.WriteLine(i); } //eğer hiçbir koşul uygulanmıyorsa o zaman sayıyı yazdırıyoruz.

            }
            Console.ReadLine(); //işlem bittikten sonra consol açık kalması için yazıyoruz.
        }
    }
}
