using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureProject
{
    class Room
    {
        //Declare Variables for Room 
        private string title;
        private string desc;
        private List<Item> items;
        private string[] exits;

        //Initialize constructors
        public string Title  { get { return title; } set { title = value; }
        }
        public string Desc { get { return desc; } set { desc = value; } }

        public Item GetItem(int i) { return items[i]; }

        public Room() { Title = ""; Desc = ""; items = null; exits = null; }

        public Room(string ttl, string des, List<Item> itm, string[] ext)
        {
            Title = ttl;
            Desc = des;
            items = itm;
            exits = ext;
        }



    }
}
