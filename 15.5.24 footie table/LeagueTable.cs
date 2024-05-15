using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15._5._24_footie_table
{
    class LeagueTable : Results
    {
        
        private Dictionary<string, Team> TeamNames = new Dictionary<string,Team>();
        
        public void Addteam(Team A)
        {    
            TeamNames.Add(A.TeamName, A);    
        }
        public void BuildTable()
        {
            foreach (KeyValuePair<string, Team> T in TeamNames)
            {
                Console.Write(T.Value.TeamName);
                T.Value.TeamResults.display();

            }
        }
        
        
        
    }
}
