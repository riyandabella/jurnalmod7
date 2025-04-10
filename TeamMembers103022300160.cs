using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmod7
{
    class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public long nim { get; set; }
    }
    class TeamMembers103022300160
    {
        public List<Members> members { get; set; }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Praktikum Konstruksi PL\\Jurnal7\\jurnalmod7\\jurnal7_2_103022300160.json");
            TeamMembers103022300160 team = JsonSerializer.Deserialize<TeamMembers103022300160>(jsonString);

            Console.WriteLine($"Team member list: ");
            int i = 0;
            foreach(var memb in team.members)
            {
                Console.WriteLine($"{team.memb.nim[i]} {team.mem.mem[i]} {team.mem.lastName[i]} ({team.mem.Average[i]} {team.mem.gender[i]");
                i++;
            }
        }
    }
}
