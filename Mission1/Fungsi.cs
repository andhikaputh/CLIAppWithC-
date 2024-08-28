using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    internal class Fungsi
    {
        string nama;
        string alamat;
        string nomorTelpon;
        List<Fungsi> dataKonsumen = new List<Fungsi>();

        public Fungsi(string nama, string alamat, string nomorTelpon)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.nomorTelpon = nomorTelpon;
        }

        public Fungsi()
        {
        }
        public override string ToString()
        {
            return $"Nama : {nama}, Alamat : {alamat}, Nomor Telepon : {nomorTelpon}";
        }

        public void InputDataKonsumen() {
            Console.Write("Masukkan nama : ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan alamat : ");
            string alamat = Console.ReadLine();
            Console.Write("Masukkan nomor telepon : ");
            string nomorTelpon = Console.ReadLine();
            bool isNumber = int.TryParse(nomorTelpon, out int number);

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(alamat) || string.IsNullOrWhiteSpace(nomorTelpon))
            {
                Console.WriteLine("Data input tidak lengkap. Lengkapkan semua inputnya");
            }
            else if (!isNumber) {
                Console.WriteLine("Masukkan nomor telepon adalah angka");
            }

            else
            {
                dataKonsumen.Add(new Fungsi(nama, alamat, nomorTelpon));
                Console.WriteLine("Data konsumen berhasil ditambah");
            }
        }

        public void OutputDataKonsumen() {
            Console.WriteLine("Data Konsumen :");
            foreach (var konsumen in dataKonsumen)
            {
                Console.WriteLine(konsumen);
            }
        }

        public void SearchingData() {
            Console.Write("Masukkan yang ingin di search :");
            string find = Console.ReadLine();

            var hasil = dataKonsumen.FindAll(k =>k.nama.IndexOf(find, StringComparison.OrdinalIgnoreCase) >=0 || k.nomorTelpon.Contains(find)
);
            if (hasil.Count >0)
            {
                foreach (var hasilKonsumen in hasil)
                {
                    Console.WriteLine($"Nama : {hasilKonsumen.nama}, Alamat : {hasilKonsumen.alamat}, Nomor Telepon : {hasilKonsumen.nomorTelpon}");
                }
            }
            else {
                Console.WriteLine("Tidak ada konsumen yang cocok");
            }
           
        }

    }
}
