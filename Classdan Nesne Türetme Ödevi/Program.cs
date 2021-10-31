using System;
using System.IO;

namespace NtpOdev1
{
	namespace Ntp
	{
		public class Tasit
		{

			public String yakit;

			public int hiz;

			public String renk;

			public String marka;

			public void arabalib()
			{
				String araba = "Taşıtın markası: " + marka + " rengi: " + renk + " yakıt tipi: " + yakit + " en fazla hızı: " + hiz;

				System.Console.WriteLine(araba);
			}
		}

		class MainClass
		{
			public static void Main(string[] args)
			{
				Tasit otomobil = new Tasit();

				otomobil.hiz = 180;

				otomobil.yakit = "LPG";

				otomobil.renk = "Kırmızı";

				otomobil.marka = "Tofaş";

				otomobil.arabalib();
	
				StreamWriter SW = new StreamWriter("C:\\ödevler\\ntp\\ödev2\\dosya.txt");
                string satır = "Dosya " +otomobil;
				SW.WriteLine(satır);

				SW.Close();
			}

		
		}
	}
}

