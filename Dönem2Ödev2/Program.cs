using System;

namespace Dönem2Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci kayıt etmek istiyorsunuz?");
            byte mevcut = byte.Parse(Console.ReadLine());



            string[,] ogrenciler = new string[mevcut + 1, 4];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Ortalama ve Harf Notu";
            


            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)

                {
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Ad giriniz:");
                            break;
                        case 1:
                            Console.WriteLine("Soyad giriniz:");
                            break;
                        case 2:
                            double vize, final, vizefinal;
                            Console.WriteLine("\n\n90-100 ile AA\n85-90 ile BA\n75-85 ile BB\n70-75 ile CB\n60-70 ile CC\n50-60 ile DC\n40-50 ile DD\n0-40 ile FF alırsın.");
                            Console.Write("\nVize Notu: "); vize = int.Parse(Console.ReadLine());
                            Console.Write("Final Notu: "); final = int.Parse(Console.ReadLine());
                            vizefinal = Math.Round((vize * 40 / 100) + (final * 60 / 100), 0);                  
                            if (vize >= 0 && vize <= 100 && final >= 0 && final <= 100)
                            {
                                Console.WriteLine("Vizenin %40'ı ve Finalin %60'ı ile {0} düşer.", vizefinal);
                            }

                            if (vizefinal > 90 && vizefinal< 100)
                            {
                                Console.WriteLine("AA ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 85 && vizefinal < 90)
                            {
                                Console.WriteLine("BA ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 75 && vizefinal < 85)
                            {
                                Console.WriteLine("BB ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 70 && vizefinal < 75)
                            {
                                Console.WriteLine("CB ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 60 && vizefinal < 70)
                            {
                                Console.WriteLine("CC ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 50 && vizefinal < 60)
                            {
                                Console.WriteLine("DC ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 40 && vizefinal < 50)
                            {
                                Console.WriteLine("DD ile dersi geçtiniz.");
                            }
                            else if (vizefinal > 0 && vizefinal < 40)
                            {
                                Console.WriteLine("FF ile KALDINIZ!");
                            }
                            else Console.WriteLine("Vize ve Uygulama Notu 0 ile 100 arasında olmalıdır.");
                            Console.WriteLine("\n\nTeyit etmek üstte geçen ortalamanızı ve harf notunuzu arasında boşluk bırakarak yazınız");

                            break;


                        default:
                            break;
                    }
                    ogrenciler[i, j] = Console.ReadLine();
                }

            }
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
