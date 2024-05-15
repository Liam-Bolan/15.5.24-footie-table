using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._5._24_footie_table
{
    public class Team
    {
        protected string _teamName;
        private string _manager;
        private int _managernum;
        private Results _teamResults;

        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }
        public string Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        public int ManagerNum
        {
            get { return _managernum; }
            set { _managernum = value; }
        }

        public Results TeamResults { get => _teamResults; set => _teamResults = value; }

        public Team()
        {
            Console.Write("Enter Teamname: ");
            _teamName = Console.ReadLine();
            Console.Write("Enter Manager name: ");
            _manager = Console.ReadLine();
            Console.Write("Enter Manager Number: ");
            _managernum = int.Parse(Console.ReadLine());
        }
    }
}
