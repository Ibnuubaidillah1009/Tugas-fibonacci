using System;

class Program
{
    static void Main()
    {
        // Variabel untuk mengontrol pengulangan program
        bool repeat = true; 

        // Loop ini akan terus berjalan selama repeat bernilai true
        while (repeat)
        {
            // Meminta pengguna untuk memasukkan jumlah bilangan Fibonacci yang ingin ditampilkan
            Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
            int n = int.Parse(Console.ReadLine()); // Mengubah input string menjadi integer

            // Inisialisasi variabel untuk menghitung bilangan Fibonacci
            int a = 0, b = 1, next;

            // Menampilkan judul untuk bilangan Fibonacci
            Console.WriteLine("Bilangan Fibonacci:");
            // Loop untuk menghitung dan menampilkan bilangan Fibonacci
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " "); // Mencetak nilai a (bilangan Fibonacci saat ini)

                // Menghitung bilangan Fibonacci berikutnya
                next = a + b; 
                a = b; // Memperbarui nilai a
                b = next; // Memperbarui nilai b
            }

            // Menanyakan kepada pengguna apakah ingin mengulang program
            Console.WriteLine("\nApakah Anda ingin mengulang? (y/n): ");
            char choice = Console.ReadKey().KeyChar; // Membaca input pengguna tanpa menekan Enter
            Console.WriteLine(); // Membuat baris baru setelah input

            // Mengatur nilai repeat berdasarkan pilihan pengguna
            repeat = (choice == 'y' || choice == 'Y'); // Jika pengguna memilih 'y' atau 'Y', program akan diulang
        }
    }
}