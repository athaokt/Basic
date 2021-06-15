using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace firstProject
{
    class Menu
    {
        public int Id { get; set; }
        public string NamaMenu { get; set; }
        public int HargaMenu { get; set; }
        public int TotalBeli { get; set; }
        public int JumlahBeli { get; set; }
        public int Transaksi { get; set; }
        public static int nextId;


        public int MenuId { get; private set; }

        public Menu(string namaMenu, int hargaMenu)
        {
            MenuId = Interlocked.Increment(ref nextId);
            NamaMenu = namaMenu;
            HargaMenu = hargaMenu;
        }

        public int TotalTransaksi(int total, int harga)
        {
            return JumlahBeli * HargaMenu;
        }
        public void ShowMenu()
        {
            Console.WriteLine($"{MenuId}. {NamaMenu}\t{HargaMenu}");
        }

        public void PilihMenu()
        {
            Console.Write($"Berapa {NamaMenu} yang anda inginkan? ");
            JumlahBeli = Convert.ToInt32(Console.ReadLine());
            Transaksi = JumlahBeli;
            TotalBeli = TotalTransaksi(Transaksi, HargaMenu);
        }

        
    }
}
