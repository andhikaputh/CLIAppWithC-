using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fungsi obj = new Fungsi();
            while (true) {
                Console.WriteLine("Menu :");
                Console.WriteLine("1 Input Data Konsumen:");
                Console.WriteLine("2 Output Data Konsumen:");
                Console.WriteLine("3 Searching:");
                Console.WriteLine("4 Keluar:");
                Console.Write(">> Pilihan anda : ");

                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        obj.InputDataKonsumen();
                        break;
                    case "2":
                        obj.OutputDataKonsumen();
                        break;
                    case "3":
                        obj.SearchingData();
                        break;
                    case "4":
                        Console.WriteLine("Keluar");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid");
                        break;
                }
            }

           
        }
        
    }
}
