using System;

namespace Dönem2Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayı üretmek istersiniz = ");
            byte adet = byte.Parse(Console.ReadLine());

            Console.Write("Üretilecek Sayılar Kaçtan Başlasın= ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üretilecek Sayılar Kaçta Bitsin= ");
            int bitis = Convert.ToInt32(Console.ReadLine());


            Random rnd = new Random();
            int[] sayilar = new int[adet];

            

                for (int i = 0; i < sayilar.Length; i++)
            {

               sayilar[i] = rnd.Next(baslangic, bitis);

                for (int kontrol =0; kontrol<i; kontrol++)

                {
                    if (sayilar[kontrol] ==sayilar[i])
                    {
                        i--;
                        break;
                    }

                }
            }

            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
