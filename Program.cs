using System;
using System.Security.Cryptography.X509Certificates;

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
        class SimpleDataBase<T>
        {
            private List<T> StoredData;
            private List<DateTime> inputDates;

            public SimpleDataBase()
            {
                StoredData = new List<T>();
                inputDates = new List<DateTime>();
            }

            public void AddNewData(T Data)
            {
                StoredData.Add(Data);
                inputDates.Add(DateTime.Now);
            }

            public void printAllData()
            {
                for (int i = 0; i < StoredData.Count; i++)
                {
                    Console.WriteLine($"Data{i + 1}berisi:{StoredData},yang disimpan pada waktu utc:{inputDates[i]}");
                }
            }
        }

        
        public static void Main(string[] args) {
            string nim1 = Console.ReadLine();
            PemrosesData data = new PemrosesData();
            int terbesar = data.DapatkanNilaiTerbesar(10, 30, 22);
                Console.WriteLine(terbesar);

            SimpleDataBase <int> dataBase = new SimpleDataBase<int>();
            dataBase.AddNewData(10);
            dataBase.AddNewData(30);
            dataBase.AddNewData(22);
            dataBase.printAllData();

        }


    }
}

