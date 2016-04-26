using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace adventureProject
=======
namespace TextAdventure
>>>>>>> pr/4
{
    class Room
    {
        //Declare Variables for Room 
        private string title;
        private string desc;
<<<<<<< HEAD
        private List<Item> items;
        private string[] exits;

        //Initialize constructors
        public string Title  { get { return title; } set { title = value; }
        }
        public string Desc { get { return desc; } set { desc = value; } }

        public Item GetItem(int i) { return items[i]; }

        public Room() { Title = ""; Desc = ""; items = null; exits = null; }
=======
        public List<Item> roomInv;
        private string[] exits;

        //Initialize constructors
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Desc { get { return desc; } set { desc = value; } }

        public bool AddItem(string item)
        {
            return Inventory.Add(roomInv, item);
        }
    

        public bool RemoveItem(string item)
        /* RemoveItem method will remove from Room Inventory
         * If the quantity of the given item is 1, the item will be
         *      removed entirely from the inventory list
         * If there is more than 1 of the given item, the 
         *      quantity will be adjusted
         */
        {
            return Inventory.Remove(roomInv, item);
        }

        public Room() { Title = ""; Desc = ""; roomInv = null; exits = null; }
>>>>>>> pr/4

        public Room(string ttl, string des, List<Item> itm, string[] ext)
        {
            Title = ttl;
            Desc = des;
<<<<<<< HEAD
            items = itm;
            exits = ext;
        }



=======
            roomInv = itm;
            exits = ext;
        }
>>>>>>> pr/4
    }
}
