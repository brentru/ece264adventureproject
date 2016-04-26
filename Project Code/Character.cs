using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Character
    {
        private string name;
        private List<Item> inv;
        private Room pos;
        private int weight;

        public string Name { get { return name; } set { name = value; } } 
        public Room Position { get { return pos; } set { pos = value; } }
        public int CarryWeight { get { return weight; } set { weight = value; } }
        
        public bool Take(string item)
        /* Take Function will remove from Room Inventory
            *      and add to player inventory.
            * If the item will cause the player to go over their max
            *      weight limit, they cannot take the item
            * If the user does not contain the item already,
            *      they will be assigned the item with a quantity of 1
            * If the user already has the item in Inventory,
            *      the quantity property will be increased
        */
        {
            if (!AddWeight(item)) return false;
            if (pos.RemoveItem(item))
            {
                if (Inventory.IsLocated(inv,item)) Inventory.AddQnt(inv,item);
                else Inventory.AddNewItem(Inventory.MyItem(pos.roomInv,item),inv);
                return true;
            }
            return false;
        }

        public bool Remove(string item)
        /* Remove will take an item from the users
         *      inventory and store it in the room
         * If the given item is not contained in the 
         *      inventory, method returns false
        */      
        {
            if (Inventory.IsLocated(inv, item))
            {
                Inventory.Remove(inv, item);
                pos.AddItem(item);
                return true;
            }
        return false;
        }

        public Character(string nme, List<Item> invt, Room myPos, int wgt) { Name = nme; inv = invt;
            Position = myPos; CarryWeight = wgt; }

       /* private void addQnt(Item i) { inv[inv.FindIndex(x => x.Title.Equals(i.Title))].Qnt++; }
        
        private void AddNewItem(Item i)
        // Adds new item to inventory with quantity of 1
        {
            Item coin = new Item(i.Title, i.Desc, 1, i.Weight);
            inv.Add(coin);
            // Deleting the qnt from all item iterations
            // inv.ElementAt(inv.IndexOf(i)).Qnt = 1;
            // inv[inv.IndexOf(i)].Qnt = 1;
        }

        private void removeQnt(string myItem) { inv[inv.FindIndex(x => x.Title.Equals(myItem.ToUpper()))].Qnt--; }
        private bool IsLocated(string myItem) { return inv.Exists(x => x.Title.Equals(myItem.ToUpper())); }
        private int myQnt(string myItem) { return inv[inv.FindIndex(x => x.Title.Equals(myItem.ToUpper()))].Qnt; }
       */public bool AddWeight(string item)
        /* Adds total weight of current inventory
         * Returns true if sum is under the limit or if inventory is empty
         * Returns false if sum exceeds limit
        */ 
        {
            int sum = 0;
            foreach (Item x in inv) sum += x.Weight;
            if (inv.Count.Equals(0)) return true;
            if (sum + Inventory.MyItem(inv,item).Weight > CarryWeight) return false;
            return true;
            
        }
    }
}
