using System;

class Program
{
    static void Main()
    {
        bool repeat = true; // Variabel untuk mengontrol pengulangan program

        while (repeat)
        {
            Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, next;

            Console.WriteLine("Bilangan Fibonacci:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                next = a + b;
                a = b;
                b = next;
            }

            // Menanyakan kepada pengguna apakah ingin mengulang
            Console.WriteLine("\nApakah Anda ingin mengulang? (y/n): ");
            char choice = Console.ReadKey().KeyChar; // Membaca input pengguna tanpa menekan Enter
            Console.WriteLine(); // Untuk membuat baris baru setelah input

            // Mengatur nilai repeat berdasarkan pilihan pengguna
            repeat = (choice == 'y' || choice == 'Y');
        }
    }
}