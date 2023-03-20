using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Sederhana
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("~~~~~~~~~~~~~~~~~~~~ \nKalkulator sederhana \n~~~~~~~~~~~~~~~~~~~~");
				Console.WriteLine("Masukkan operator matematika yang ingin dipilih:");
				Console.WriteLine("1. Penjumlahan (+)");
				Console.WriteLine("2. Pengurangan (-)");
				Console.WriteLine("3. Perkalian (x)");
				Console.WriteLine("4. Pembagian (/)");
				Console.WriteLine("5. Keluar");

				Console.Write("\nPilih: ");
				string operasi = Console.ReadLine();

				switch (operasi)
				{
					case "1":
						Console.Write("Masukkan angka pertama: ");
						double angka1 = double.Parse(Console.ReadLine());
						Console.Write("Masukkan angka kedua: ");
						double angka2 = double.Parse(Console.ReadLine());
						double hasilJumlah = angka1 + angka2;
						Console.WriteLine("Hasil: " + hasilJumlah);
						break;
					case "2":
						Console.Write("Masukkan angka pertama: ");
						double angka3 = double.Parse(Console.ReadLine());
						Console.Write("Masukkan angka kedua: ");
						double angka4 = double.Parse(Console.ReadLine());
						double hasilKurang = angka3 - angka4;
						Console.WriteLine("Hasil: " + hasilKurang);
						break;
					case "3":
						Console.Write("Masukkan angka pertama: ");
						double angka5 = double.Parse(Console.ReadLine());
						Console.Write("Masukkan angka kedua: ");
						double angka6 = double.Parse(Console.ReadLine());
						double hasilKali = angka5 * angka6;
						Console.WriteLine("Hasil: " + hasilKali);
						break;
					case "4":
						Console.Write("Masukkan angka pertama: ");
						double angka7 = double.Parse(Console.ReadLine());
						Console.Write("Masukkan angka kedua: ");
						double angka8 = double.Parse(Console.ReadLine());
						double hasilBagi = angka7 / angka8;
						Console.WriteLine("Hasil: " + hasilBagi);
						break;
					case "5":
						Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
						Console.WriteLine("Terima kasih telah menggunakan kalkulator ini");
						Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
						return;
					default:
						Console.WriteLine("Operasi yang dipilih tidak valid.");
						break;
				}
				Console.WriteLine();



			}
		}

	}
}