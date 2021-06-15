using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            int menu;
            string beliLagi;
            int totalPembelian = 0;

            Menu menu1 = new Menu("Nasi goreng", 15000);
            Menu menu2 = new Menu("Bakmi goreng", 15000);
            Menu menu3 = new Menu("Bakmi Rebus", 15000);
            Menu menu4 = new Menu("Es Teh", 3000);
            Menu menu5 = new Menu("Es Jeruk", 5000);

            Console.WriteLine("\t\tSelamat datang di Warung Makan Pak Ahmad");
            Console.WriteLine("\t\t==========================================");
            Console.WriteLine("Kami menyediakan berbagai makanan dan minuman seperti berikut: ");
            menu1.ShowMenu();
            menu2.ShowMenu();
            menu3.ShowMenu();
            menu4.ShowMenu();
            menu5.ShowMenu();

            List<string> productPurchased = new List<string>();
            List<int> productTotal = new List<int>();
            List<Menu> ProductPurchased = new List<Menu>();

            do
            {
            first:
                try
                {
                    Console.Write("Masukkan menu pilihan anda(1-5): ");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            menu1.PilihMenu();
                            total1 = menu1.TotalBeli;
                            /*ProductPurchased.Add(new Menu(menu1.NamaMenu, menu1.HargaMenu));*/
                            productPurchased.Add(menu1.NamaMenu);
                            productTotal.Add(menu1.Transaksi);
                            break;
                        case 2:
                            menu2.PilihMenu();
                            total2 = menu2.TotalBeli;
                            productPurchased.Add(menu2.NamaMenu);
                            productTotal.Add(menu2.Transaksi);
                            break;
                        case 3:
                            menu3.PilihMenu();
                            total3 = menu3.TotalBeli;
                            productPurchased.Add(menu3.NamaMenu);
                            productTotal.Add(menu3.Transaksi);
                            break;
                        case 4:
                            menu4.PilihMenu();
                            total4 = menu4.TotalBeli;
                            productPurchased.Add(menu4.NamaMenu);
                            productTotal.Add(menu4.Transaksi);
                            break;
                        case 5:
                            menu5.PilihMenu();
                            total5 = menu5.TotalBeli;
                            productPurchased.Add(menu5.NamaMenu);
                            productTotal.Add(menu5.Transaksi);
                            break;
                        default:
                            Console.WriteLine("Masukkan angka 1-5");
                            goto first;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hanya bisa input angka");
                    goto first;
                }

                Console.Write("Apakah anda ingin membeli lagi? (y/n) ");
                beliLagi = Console.ReadLine();
            } while (beliLagi.ToLower() == "y");

            Console.Clear();

            Console.WriteLine("Berikut adalah pesanan anda: ");
            Console.WriteLine("==========================================");
            /*foreach (var purchased in ProductPurchased)
            {
                Console.WriteLine("{0}\t{1}", purchased.NamaMenu, purchased.TotalBeli);
            }*/

            for (int i = 0; i < productPurchased.Count; i++)
            {
                Console.WriteLine($"{productPurchased[i]}\t{productTotal[i]}");
            }

            Console.WriteLine("==========================================");

            totalPembelian = total1 + total2 + total3 + total4 + total5;
            Console.WriteLine("Jadi total pembelian anda adalah = Rp" + totalPembelian);
            int uang = 0;
            int kembalian = 0;
            Console.Write("Masukkan uang anda: ");

            uang = Convert.ToInt32(Console.ReadLine());
            while (uang < totalPembelian)
            {
                Console.Write("Maaf uang anda kurang mohon masukkan lagi: ");
                uang = Convert.ToInt32(Console.ReadLine());
            }
            if (uang == totalPembelian)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("Uang anda pas. Terima Kasih.");
                Console.WriteLine("==========================================");
            }
            else
            {
                kembalian = uang - totalPembelian;
                Console.WriteLine("==========================================");
                Console.WriteLine("Kembalian anda adalah: Rp" + kembalian);
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("==========================================");
            }
        }

    }
}
