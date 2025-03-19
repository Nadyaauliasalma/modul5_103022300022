using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022300022
{
    class SimpleDataBase<T>
    {
        private List<T> StoredData;
        private List<DateTime> inputDates;

        public SimpleDataBase() { 
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
}
