using System;

namespace Modul5_103022300022
{
    class program
    {
        public class PemrosesData
        {

            public T DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
            {
                dynamic Nilai1 = (dynamic)data1;
                dynamic Nilai2 = (dynamic)data2;
                dynamic Nilai3 = (dynamic)data3;

                dynamic Nilaimax = data1;

                if (Nilai2 > Nilaimax)
                    Nilaimax = Nilai2;
                if (Nilai3 > Nilaimax)
                    Nilaimax = Nilai3;

                return Nilaimax;
            }
        }
        public static void Main(string[] args) {
            string nim1 = Console.ReadLine();
            PemrosesData data = new PemrosesData();
            int terbesar = data.DapatkanNilaiTerbesar(10, 30, 22);
                Console.WriteLine(terbesar);

        }
    }
}