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
    public Address address { get; set; }
    public List<Courses> courses { get; set; }

    public static void ReadJSON()
    {
        string jsonstring = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\jurnalmod7\\jurnal7_1_103022300001.json");

        var mhs = JsonSerializer.Deserialize<DataMahasiswa103022300001>(jsonstring);

        Console.WriteLine("First Name : " + mhs.firstName);
        Console.WriteLine("Last Name : " + mhs.lastName);
        Console.WriteLine("Gender : " + mhs.gender);
        Console.WriteLine("Age : " + mhs.age);
        Console.WriteLine("Address : " + mhs.address.streetAddress + " " + mhs.address.city + " " + mhs.address.state);
        foreach (var mk in mhs.courses)
        {
            Console.WriteLine("MK : " + mk.code + " - " + mk.name);
        }
    }
}

class Members
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

class TeamMembers103022300001
{
    public List<Members> members { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\jurnalmod7\\jurnal7_2_103022300001.json");

        var member = JsonSerializer.Deserialize<TeamMembers103022300001>(jsonString);

        Console.WriteLine("Team member list: ");
        int i = 1;
        foreach (var memb in member.members)
        {
            Console.WriteLine("Anggota : " + i + " " + memb.firstName + " " + memb.lastName
                + " " + memb.gender + " " + memb.age + " " + memb.nim);
            i++;
        }
    }
}

class Glossary
{
    public string title { get; set; }
    public glossDiv GlossDiv { get; set; }
}

class glossDiv
{
    public string title { get; set; }
    public glossList GlossList { get; set; }

}

class glossList
{
    public glossEntry GlossEntry { get; set; }
}

class glossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public glossDef GlossDef { get; set; }
    public string GlossSee { get; set; }

}

class glossDef
{
    public string para { get; set; }
    public string[] GlossSeeAlso { get; set; }

}
class GlossaryItem103022300001
{
    public Glossary glossary { get; set; }

    public static void ReadJSON()
    {
        string JsonString = File.ReadAllText("C:\\Users\\riyan\\source\\repos\\jurnalmod7\\jurnal7_3_103022300001.json");

        var glossaryItem = JsonSerializer.Deserialize<GlossaryItem103022300001>(JsonString);

        Console.WriteLine("Glossary title : " + glossaryItem.glossary.title);
        Console.WriteLine("Glossary GlossDiv : ");
        Console.WriteLine("GlossDiv title : " + glossaryItem.glossary.GlossDiv.title);
        Console.WriteLine("GlossDiv GlossList : ");
        Console.WriteLine("GlossList GlossEntry : ");
        Console.WriteLine("GlossEntry ID : " + glossaryItem.glossary.GlossDiv.GlossList.GlossEntry.ID);
        Console.WriteLine("GlossEntry sortAs : " + glossaryItem.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
        Console.WriteLine("GlossEntry glossTerm : " + glossaryItem.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
        Console.WriteLine("GlossEntry acronym : " + glossaryItem.glossary.GlossDiv.GlossList.GlossEntry.Acronym);

    }
}

class Program
{
    public static void Main()
    {
        DataMahasiswa103022300001.ReadJSON();
        TeamMembers103022300001.ReadJSON();
        GlossaryItem103022300001.ReadJSON();
    }
}