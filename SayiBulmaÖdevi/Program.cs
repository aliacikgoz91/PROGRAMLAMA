using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV
{
    class Program
    {
        static void Main(string[] args)
        {
            string tahminkücült = " <-> Tahmininizi buyultünüz <-> " ;
            string tahminbüyült = " <-> Tahmininizi kücültünüz <-> " ;
            bool tahminet;
            int seviye;
            int rastgeleSayi;
            int kullaniciTahmin = 0;
            bool kontrol = false;
            int adimsayac = 1;
            Random rnd = new Random();
            Console.WriteLine("                            <-> <-> <-> SEVİYELİ SAYI TAHMİN OYUNU BAŞLIYOR <-> <-> <-> \n \n                            ");
            Console.WriteLine("Oyunumuz 3 Seviyeden Oluşmaktadır. \n \n \n Oyunun zorluk seviyesini seciniz. \n Kolay seviye[1 - 10 Arası][Tahmin Hakkı : 6] icin ‘1’ \n Orta seviye [1 - 25 Arası][Tahmin Hakkı : 4] icin ‘2’ \n Zor seviye  [1 - 50 Arası][Tahmin Hakkı : 2] icin ‘3’ giriniz:");
            bool zorluk = int.TryParse(Console.ReadLine(), out seviye);

            while (zorluk == false || seviye < 1 || seviye > 3)
            {
                Console.WriteLine("<!> <!> <!> Hatalı giriş yaptınız. Tekrar Deneyiniz. <!> <!> <!>");
                zorluk = int.TryParse(Console.ReadLine(), out seviye);
            }
            switch (seviye)
            {
                
                case 1:
                    int kolayhak = 6;
                    rastgeleSayi = rnd.Next(1, 10);
                    while (kontrol == false && kolayhak>0)
                    {
                        Console.WriteLine("[Kolay Seviye] >>> Tahmin ediniz: ");
                        tahminet = int.TryParse(Console.ReadLine(), out kullaniciTahmin);
                        if (kullaniciTahmin == rastgeleSayi)
                        {
                            Console.WriteLine(adimsayac + ". adımda buldunuz. \n < < < Tebrikler > > > ");
                            kontrol = true;
                                break;
                            
                        }
                        
                        else if (kullaniciTahmin < rastgeleSayi)
                        {
                            Console.WriteLine(tahminkücült);
                        }
                        else
                        {
                            Console.WriteLine(tahminbüyült);
                        }
                        adimsayac++;
                        kolayhak--;
                        if (kolayhak == 0) Console.WriteLine("6 hakkınızı da kullandınız. Sayı bilemediniz. Rastgele üretilen sayı =" + rastgeleSayi);
                    }
                    break;

                case 2:
                    int ortahak = 4;
                    rastgeleSayi = rnd.Next(1, 25);
                    while (kontrol == false && ortahak > 0)
                    {
                        Console.WriteLine("[Orta Seviye] >>> Tahmin ediniz: ");
                        tahminet = int.TryParse(Console.ReadLine(), out kullaniciTahmin);
                        if (kullaniciTahmin == rastgeleSayi)
                        {
                            Console.WriteLine(adimsayac + ". adımda buldunuz. \n < < < Tebrikler > > > ");
                            kontrol = true;

                                break;
                            
                        }
                        else if (kullaniciTahmin < rastgeleSayi)
                        {
                            Console.WriteLine(tahminkücült);
                        }
                        else
                        {
                            Console.WriteLine(tahminbüyült);
                        }
                        adimsayac++;
                        ortahak--;
                        if (ortahak == 0) Console.WriteLine("4 hakkınızı da kullandınız. Sayı bilemediniz. Rastgele üretilen sayı =" + rastgeleSayi);
                    }
                    break;

                case 3:
                    int zorhak = 2;
                    rastgeleSayi = rnd.Next(1, 50);
                    while (kontrol == false && zorhak > 0)
                    {
                        Console.WriteLine("[Zor Seviye] >>> Tahmin ediniz: ");
                        tahminet = int.TryParse(Console.ReadLine(), out kullaniciTahmin);
                        if (kullaniciTahmin == rastgeleSayi)
                        {
                            Console.WriteLine(adimsayac + ". adımda buldunuz. \n < < < Tebrikler > > > ");
                            kontrol = true;

                                break;
                            
                        }
                        else if (kullaniciTahmin < rastgeleSayi)
                        {
                            Console.WriteLine(tahminkücült);
                        }
                        else
                        {
                            Console.WriteLine(tahminbüyült);
                        }
                        adimsayac++;
                        zorhak--;
                        if (zorhak == 0) Console.WriteLine("2 hakkınızı da kullandınız. Sayı bilemediniz. Rastgele üretilen sayı =" + rastgeleSayi);
                    }
                    break;
            }
            Console.ReadKey();


        }
    }
}
