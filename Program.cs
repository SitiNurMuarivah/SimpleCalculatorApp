/* Technical Assignment Skilvul - Game Development
Create a Simple Calculator App
Nama    : Siti Nur Mu'arivah
Group   : Kelompok 4
Mentor  : M. Arief Ismirianda
*/

using System;
namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string? input = string.Empty;
            string? pilih = string.Empty;
            int nilai1, nilai2, menu;
            bool jwbn = false;

            do
            {
                Console.Clear();
                Console.WriteLine("***********Simple Calculator App***********");
                Console.WriteLine("*******************************************");
                Console.Write("Masukkan angka ke-1 = ");
                nilai1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka ke-2 = ");
                nilai2 = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("\n-------------Menu-------------");
                    Console.WriteLine("Pilih Operasi Perhitungan:");
                    Console.WriteLine("1. Penambahan  (+)");
                    Console.WriteLine("2. Pengurangan (-)");
                    Console.WriteLine("3. Perkalian   (*)");
                    Console.WriteLine("4. Pembagian   (/)");
                    Console.WriteLine("------------------------------");

                    Console.Write("Masukkan menu operasi perhitungan (1-4) = ");
                    menu = Convert.ToInt32(Console.ReadLine());

                    if (menu == 1 || menu == 2 || menu == 3 || menu == 4)
                    {
                        jwbn = true;
                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("\nHasil dari " + nilai1 + " + " + nilai2 + " adalah = " + tambah(nilai1, nilai2));
                                break;
                            case 2:
                                Console.WriteLine("\nHasil dari " + nilai1 + " - " + nilai2 + " adalah = " + kurang(nilai1, nilai2));
                                break;
                            case 3:
                                Console.WriteLine("\nHasil dari " + nilai1 + " * " + nilai2 + " adalah = " + kali(nilai1, nilai2));
                                break;
                            case 4:
                                if (nilai2 == 0)
                                {
                                    Console.WriteLine("\nError: Pembagian dengan nol tidak dapat dilakukan");
                                }
                                else
                                {
                                    Console.WriteLine("\nHasil dari " + nilai1 + " / " + nilai2 + " adalah = " + bagi(nilai1, nilai2));
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nMohon masukkan menu yang tersedia (1-4).");
                    }
                }
                while (jwbn == false);

                Console.Write("\nApakah ingin melanjutkan perhitungan (y/n)? ");
                input = Console.ReadLine();
            }
            while (input == "y" || input == "Y");
            Console.WriteLine("\nSampai Jumpa Kembali.");
        }

        public static int tambah(int nilai1, int nilai2)
        {
            return nilai1 + nilai2;
        }
        public static int kurang(int nilai1, int nilai2)
        {
            return nilai1 - nilai2;
        }
        public static int kali(int nilai1, int nilai2)
        {
            return nilai1 * nilai2;
        }
        public static double bagi(float nilai1, float nilai2)
        {
            return nilai1 / nilai2;
        }
    }
}

