using System;


namespace TugasMinggu3
{
	public class Mobil
	{

		// property
		public string Warna { get; set; }
		public int JumlahPintu { get; set; }
		public string Merek { get; set; }
		public string Model { get; set; }
		public int TahunKeluaran { get; set; }

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
			Console.WriteLine("Mobil saya berwarna " + Warna + ", merek " + Merek + ", model " + Model + " keluaran tahun " + TahunKeluaran + " dengan jumlah pintu sebanyak " + JumlahPintu +"");
		}
	}
}
