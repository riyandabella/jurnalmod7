using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


public class address_103022300099
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Courses
{
    public string code { get; set; }
    public string name { get; set; }
}
public class DataMahasiswa_103022300099
{
    public string firstName { get; set; }
    public string Lastname { get; set; }

    public long age { get; set; }
    public string address { get; set;}

    public List<Courses> courses { get; set; }
    public static void ReadSON()
    {
        string jsonPath = "D:\\jurnalMod7_103022300099\\jurnalmod7\\jurnal7_1_103022300099.json";

        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("File JSON tidak ditemukan.");
            return;
        }
        string JsonData = File.ReadAllText(jsonPath);
        var data = JsonSerializer.Deserialize<DataMahasiswa_103022300099>(JsonData);

        Console.WriteLine("=== Hasil Deserialisasi JSON ===");
        Console.WriteLine($"firstname : {data.name} ");
        Console.WriteLine($"Lasttname : {data.name} ");
        Console.WriteLine($"Gender  : {data.gender} ");
        Console.WriteLine($"age : {data.age} ");
        Console.WriteLine($"Address : {data.address} ");
        Console.WriteLine($"courses  : {data.courses} ");
        
    }

}

public class Program
{
     static void Main(string[] args)
    {
        DataMahasiswa_103022300099.ReadSON();
    }
}