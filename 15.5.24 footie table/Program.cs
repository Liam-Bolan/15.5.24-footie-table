using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._5._24_footie_table
{
    internal class Program
    {
        public static LeagueTable ThisTable = new LeagueTable();
        static void Main(string[] args)
        {
            
            
            char option;
            Menu();
            option = Console.ReadLine().ToUpper()[0];
            switch (option)
            {
                case '1':
                    AddTeam();
                    return;
                
                case '2':
                    ThisTable.BuildTable();
                    break;
                case '3':
                    return;
                    





            }
            
        }
        static void Menu()
        {
            Console.WriteLine("1. Add team");
            Console.WriteLine("2. View table");
            Console.WriteLine("3. Exit");
            
        }
        static void AddTeam()
        {
            Team newTeam = new Team(); //instantiate new team.

        }
        

    }
}
