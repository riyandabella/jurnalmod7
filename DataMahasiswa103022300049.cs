using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmod7
{
    class DataMahasiswa103022300049
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Address address { get; set; }
        public List<Course> Courses { get; set; }

        public DataMahasiswa103022300049()
        {

        }
        public DataMahasiswa103022300049(string FirstName, String LastName, string Gender, int Age, Address address, List<Course> Courses)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Age = Age;
            this.address = address;
            this.Courses = Courses;
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:/mod7/jurnalmod7/jurnal7_1_103022300049.json");
            var data = JsonSerializer.Deserialize<DataMahasiswa103022300049>(jsonString);

            Console.WriteLine("=== Data Mahasiswa ===");
            Console.WriteLine($"Nama  : {data.FirstName} {data.LastName}");
            Console.WriteLine($"Umur  : {data.Age}");
            Console.WriteLine($"Alamat  : {data.address.StreetAddress}, {data.address.City}, {data.address.State}");
            Console.WriteLine("Mata Kuliah");

            foreach (var course in data.Courses)
            {
                Console.WriteLine($"- {course.Code} : {course.Name}");
            }

        }
    }

    class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public Course (string Code, string Name)
        {
            this.Code = Code;
            this.Name = Name;
        }
    }

    
}
