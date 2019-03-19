using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa 
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu 
            saya.Nim = "12345";
            saya.Nama = "Reza";
            saya.Ipk = 2;

            kamu.Nim = "12345";
            kamu.Nama = "anton";
            kamu.Ipk = 3;

            // memanggil methode registrasi dan isi Krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
              
        }
    }
}
