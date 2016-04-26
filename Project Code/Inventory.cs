using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    static class Inventory
    {
        // Adds item to inventory
        public static bool Add(List<Item> inv, string item)
        {
            if (Inventory.IsLocated(inv, item))
            {
                if (Inventory.IsLocated(inv, item)) Inventory.AddQnt(inv, item);
                else Inventory.AddNewItem(inv, item);
                return true;
            }
            return false;
        }
        // Removes item from inventory
        public static bool Remove(List<Item> inv, string item)
        {
            if (Inventory.IsLocated(inv, item))
            {
                if (Inventory.MyQnt(inv, item).Equals(1)) inv.Remove(Inventory.MyItem(inv, item));
                else Inventory.SubQnt(inv, item);
                return true;
            }
            return false;
        }
        // Returns true if item is located in inventory, false if not
        public static bool IsLocated(List<Item> inv, string item) { return inv.Exists(x => x.Title.Equals(item.ToUpper())); }
        // Returns item in inventory
        public static Item MyItem(List<Item> inv, string item) { return inv.Find(x => x.Title.Equals(item.ToUpper())); }
        // Returns quantity of given item in inventory
        public static int MyQnt(List<Item> inv, string item) { return inv[inv.FindIndex(x => x.Title.Equals(item.ToUpper()))].Qnt; }
        // Adds quantity of given item in inventory
        public static void AddQnt(List<Item> inv, string item) { Inventory.MyItem(inv, item).Qnt++; }
        // Subtracts quantity of given item in inventory
        public static void SubQnt(List<Item> inv, string item) { Inventory.MyItem(inv,item).Qnt--; }
        // Adds a new instantiation of an item in inventory with a quantity of 1
        public static void AddNewItem(Item i,List<Item> inv)
        {
            Item newItem = new Item();
            newItem = i;
            inv.Add(newItem);
        }


    }
}
