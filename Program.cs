using System;
using System.IO;
using System.Text.Json;


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

class DataMahasiswa103022300001
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address adr { get; set; }
    public List<Courses> courses { get; set; }

    public static void ReadJSON()
    {
        string jsonstring = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\jurnalmod7\\jurnal7_1_103022300001.json");

        var mhs = JsonSerializer.Deserialize<DataMahasiswa103022300001>(jsonstring);

        Console.WriteLine("First Name : " + mhs.firstName);
        Console.WriteLine("Last Name : " + mhs.lastName);
        Console.WriteLine("Gender : " + mhs.gender);
        Console.WriteLine("Age : " + mhs.age);
        Console.WriteLine("Address : " + mhs.adr.streetAddress + " " + mhs.adr.city + " " + mhs.adr.state);
        foreach (var mk in mhs.courses)
        {
            Console.WriteLine("MK : " + mk.code + " - " + mk.name);
        }
    }
}

class Program
{
    public static void Main()
    {
        DataMahasiswa103022300001.ReadJSON();
    }
}