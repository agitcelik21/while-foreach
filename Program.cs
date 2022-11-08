using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            // While
            // 1 den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console yazdıran program.
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);
            
            // 'a' dan 'z' ye kadar tüm harfleri console yazdır.
            char character= 'a';
            while (character<='z')
            {
                Console.Write(character);
                character ++;
            }

            // foreach
            Console.WriteLine("***** Foreach *****");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadKey();
        }
    }
}