using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPemrogramanPraktikum4
{
	internal class Mobil
	{
		// field
		private string _WarnaMobil;
		private int _JumlahPintuMobil;
		private string _MerekMobil;
		private string _ModelMobil;
		private int _TahunKeluaranMobil;
		
		// property
		public string Warna
		{
			get
			{
				return _WarnaMobil;
			}
			set
			{
				_WarnaMobil = value;
			}
		}

		public int JumlahPintu
		{
			get
			{
				return _JumlahPintuMobil;
			}
			set
			{
				_JumlahPintuMobil = value;
			}
		}

		public string Merek
		{
			get
			{
				return _MerekMobil;
			}
			set
			{
				_MerekMobil = value;
			}
		}

		public string Model
		{
			get
			{
				return _ModelMobil;
			}
			set
			{
				_ModelMobil = value;
			}
		}

		public int TahunKeluaran
		{
			get
			{
				return _TahunKeluaranMobil;
			}
			set
			{
				_TahunKeluaranMobil = value;
			}
		}




		// method
		public void PropertyMobil()
		{
			Console.WriteLine("Warna          : {0}", Warna);
			Console.WriteLine("Jumlah Pintu   : {0}", JumlahPintu);
			Console.WriteLine("Merek          : {0}", Merek);
			Console.WriteLine("Model          : {0}", Model);
			Console.WriteLine("Tahun Keluaran : {0}", TahunKeluaran);
		}

		public void Gas(int Kecepatan)
		{
			Console.WriteLine("\nMobil " + Model + " berjalan dengan kecepatan " + Kecepatan + "\n");
		}

		public void Klakson(string Suara)
		{
			Console.WriteLine("{0}\n", Suara);
		}

		public void TampilanInfo()
		{
			Console.WriteLine("Mobil saya berwarna " + Warna + ", merek " + Merek + ", model " + Model + " keluaran tahun " + TahunKeluaran + " dengan jumlah pintu sebanyak " + JumlahPintu + "");
		}
	}
}
