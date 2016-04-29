using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Room:Inventory
    {
        private string title;
        private string desc;
        private List<Item> inv;
        private string[] exits;

        public override List<Item> Inv { get { return inv; } set { inv = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Desc { get { return desc; } set { desc = value; } }

        public Room() { Title = ""; Desc = ""; inv = null; ; exits = null; }

        public Room(string ttl, string des, List<Item> itm, string[] ext)
        {
            Title = ttl;
            Desc = des;
            inv = itm;
            exits = ext;
        }
    }
}
