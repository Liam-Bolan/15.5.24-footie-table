using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _15._5._24_footie_table
{
    public class Results
    {
        private int _gplayed;
        private int _gwon;
        private int _glost;
        private int _gdrew;
        private int _points;

        public int GPlayed
        {
            get { return _gplayed; }
            set { _gplayed = value; }
        }
        public int GWon
        {
            get { return _gwon; }
            set { _gwon = value; }
        }
        public int GLost
        {
            get { return _glost; }
            set { _glost = value; }
        }
        public int GDrew
        {
            get { return _gdrew; }
            set { _gdrew = value; }
        }
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public void display()
        {
            Console.WriteLine($"w:{GWon} d:{GDrew} l:{GLost} gp:{GPlayed} p:{Points}");
        }

    }
}
