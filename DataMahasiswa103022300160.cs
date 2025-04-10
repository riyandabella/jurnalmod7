using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmod7
{
    class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    class DataMahasiswa103022300160
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Praktikum Konstruksi PL\\Jurnal7\\jurnalmod7\\jurnal7_1_103022300160.json");
            DataMahasiswa103022300160 data = JsonSerializer.Deserialize<DataMahasiswa103022300160>(jsonString);
            Console.WriteLine($"Nama {data.firstName} {data.lastName} gender {data.gender} umur {data.age} tahun");
            Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.city}, provinsi {data.address.state}");
            Console.WriteLine($"Mata Kuliah yang diambil: ");
            
            for(int i = 0; i < data.courses.Count; i++)
            {
                Console.WriteLine($"{data.courses[i].code} {data.courses[i].name}");
            }
        }

    }
}
