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

            Console.WriteLine("*****Simple Calculator App***** \n");
            Console.Write("Masukkan angka ke-1: ");
            nilai1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka ke-2: ");
            nilai2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("\n-------------Menu-------------");
                Console.WriteLine("Pilih Operasi Perhitungan:");
                Console.WriteLine("1. Penambahan  (+)");
                Console.WriteLine("2. Pengurangan (-)");
                Console.WriteLine("3. Perklian    (*)");
                Console.WriteLine("4. Pembagian   (:)");
                Console.WriteLine("------------------------------\n");

                Console.Write("Masukkan menu operasi perhitungan yang dipilih: ");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1 || menu == 2 || menu == 3 || menu == 4)
                {
                    jwbn = true;
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Hasil dari " + nilai1 + " + " + nilai2 + " = " + tambah(nilai1, nilai2));
                            break;
                        case 2:
                            Console.WriteLine("Hasil dari " + nilai1 + " - " + nilai2 + " = " + kurang(nilai1, nilai2));
                            break;
                        case 3:
                            Console.WriteLine("Hasil dari " + nilai1 + " * " + nilai2 + " = " + kali(nilai1, nilai2));
                            break;
                        case 4:
                            Console.WriteLine("Hasil dari " + nilai1 + " / " + nilai2 + " = " + bagi(nilai1, nilai2));
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInput tidak valid. Masukkan Menu antara 1-4");
                }
            }
            while (jwbn == false);
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
        public static int bagi(int nilai1, int nilai2)
        {
            return nilai1 / nilai2;
        }
    }
}

