using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    { 
        //deklrasi array int dengan ukuran 53
        private int[] rania = new int[53];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            //menirima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: "); 
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 53)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 53 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                rania[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int RP = 0; RP < n; RP++)
            {
                Console.WriteLine(rania[RP]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int RP = 0; RP < n; RP++)
                {
                    if (rania[RP] > rania[RP + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = rania[RP];
                        rania[RP] = rania[RP + 1];
                        rania[RP + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // crwaring the object of the BubbleSort class
            Program mylist = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();

            //pemanggilan fungsi untuk mengurutkan array 
            mylist.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            //exit
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }

}