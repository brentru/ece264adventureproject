using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Character:Inventory
    {
        private string name;
        private Room pos;
        private int weight;
        public List<Item> inv;

        public string Name { get { return name; } set { name = value; } }
        public Room Position { get { return pos; } set { pos = value; } }
        public int CarryWeight { get { return weight; } set { weight = value; } }
        public override List<Item> Inv { get { return inv; } set { inv = value; } }

        // Adds the specified item to the character's inventory if it is located 
        // inside the current room and if they can carry it
        public bool Take(string item)
        {
            if (pos.IsLocated(item))
            {
                if (CanCarry(item))
                {
                    // The added item must be copied from the source (pos) in order to properly add 
                    AddItem(pos.CopyItem(item));
                    pos.RemoveItem(item);
                    return true;
                }
            }
            return false;
        }

        // Removes the specified item from the character's inventory if it is located 
        // inside their inventory
        public bool Remove(string item)
        {
            if (IsLocated(item))
            {
                // The added item must be copied from the source (player) in order to properly add 
                pos.AddItem(CopyItem(item));
                RemoveItem(item);
                return true;
            }
            return false;
        }

        // Prints description of given item in inventory and returns true if located. If no item exists, returns false
        public bool ViewItem(string item)
        {
            if (IsLocated(item))
            {
                PrintDesc(item);
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you do not have that item");
                return false;
            } 
        }

        // Prints out items inside inventory
        public void ViewInventory()
        {
            if (inv.Count.Equals(0)) Console.WriteLine("You have no items in you inventory");
            else PrintInv();
        }

        public Character(string nme, List<Item> i,Room myPos, int wgt) { Name = nme; 
            Position = myPos; inv = i; CarryWeight = wgt; }

        

    }
}
