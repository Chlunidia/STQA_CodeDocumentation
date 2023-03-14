using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// <summary>
// Operasi untuk memasukkan nilai
// </summary>
namespace Decision_Making_With_Different_Method
{
    // <summary>
    // Operasi untuk memasukkan nilai.
    // </summary>
    // <remarks> Class InputData digunakan untuk menjalankan operasi untuk memasukkan data nim dan nilai.  </remarks>
    // <param name="nilM"> Menerima input nilai Matematika. </param>
    // <param name="nimB"> Menerima input nilai Bahasa Inggris. </param>
    class InputData
    {
        // <summary>
        // <remarks> Funtion ini merupakan deklarasi dari semua variabel untuk memasukkan data yang diinput oleh user. </remarks>
        // <param name="nilM"> Menerima input nilai Matematika. </param>
        // <param name="nimB"> Menerima input nilai Bahasa Inggris. </param>
        // <remarks> Double digunakan untuk menjumlahkan bilangan. </remarks>
        // </summary>
        public double nilM, nilB;
        public double InputNilaiM()
        {
            // Display 'Masukkan Nilai Matematika = '
            Console.Write("Masukan nilai Matematika = ");
            // Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());
            return nilM;
        }

        public double InputNilaiB()
        {
            // Display 'Masukkan Nilai Bahasa Inggris = '
            Console.Write("Masukkan nilai Bahasa Inggris = ");
            nilB = Convert.ToDouble(Console.ReadLine());
            return nilB;
        }
    }
    // <summary>
    // Operasi untuk menentukan rerata nilai yang telah dimasukkan oleh user.
    // </summary>
    // <remarks> Class ProsesData membuat operasi untuk menentukan rerata. </remarks>
    class ProsesData
    {
        // <summary>
        // <remarks> Variabel rerata digunakan untuk mendeklarasikan rerata nilai yang telah dihitung. </remarks>
        // </summary>
        // <param name = "rerata"> Menyimpan data rerata nilai yang telah diinput oleh user. </param>
        // <returns> Hasil dari perhitungan rerata nilai Matematika dan Bahasa Inggris. </returns>
        public double rerata;
        public double Hitung(double nilM, double nilB)
        {
            rerata = (nilM + nilB) / 2;
            return rerata;
        }
    }
    // <summary>
    // Operasi untuk menentukan status nilai.
    // </summary>
    // <remarks> Class OutputData membuat operasi untuk menentukan status. </remarks>
    class OutputData
    {
        // <summary>
        // <remarks> Variabel status digunakan untuk mendeklarasikan status nilai yang telah direrata. </remarks>
        // </summary>
        public string status;
        // <summary>
        // Operasi untuk menentukan status nilai.
        // </summary>
        // <param name="rerata"> Menerima input nilai rerata yang sudah dihitung. </param>
        // <param name="nilM"> Menerima input nilai Matematika. </param>
        // <remarks> nFunction ini berfungsi untuk menentukan hasil rerata nilai yang telah dimasukkan user berstatus lulus atau gagal. </remarks>
        public void Hasil(double rerata, double nilM)
        {
            // if (rerata >= 60 AND nilM >= 70)
            if (rerata >= 60 & nilM >= 70)
            { // Begin
                // Status = 'lulus'
                Console.WriteLine("Lulus");
            } // End
            else
            { // Begin
                // Status = 'Gagal'
                Console.WriteLine("Gagal");
            } // End
        }

        public void Status(string status)
        {
            Console.WriteLine("Status peserta adalah {0}", status);
        }
    }

    // <summary>
    // Main class
    // </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // initiate Class
            InputData id = new InputData();
            ProsesData pd = new ProsesData();
            OutputData od = new OutputData();

            // panggil method untuk input data
            id.InputNilaiM();
            id.InputNilaiB();

            // panggil method untuk proses data
            pd.Hitung(id.nilM, id.nilB);

            // panggil method untuk output  data
            od.Status(od.status);
            od.Hasil(pd.rerata, id.nilM);

            Console.ReadKey();
        }
    }
}