using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TugasPemrogramanPraktikum4
{
	internal class Program
	{
		class program
		{

			static void Main(string[] args)
			{
				Mobil mobil1 = new Mobil();
				mobil1.Warna = "Biru Tua";
				mobil1.JumlahPintu = 4;
				mobil1.Merek = "Toyota";
				mobil1.Model = "Supra";
				mobil1.TahunKeluaran = 2023;

				mobil1.PropertyMobil();
				mobil1.Gas(65);
				mobil1.Klakson("Beep-beep");
				mobil1.TampilanInfo();
			}
		}

	}
}

