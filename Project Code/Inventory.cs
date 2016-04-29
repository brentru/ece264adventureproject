using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Inventory
    {
        //private List<Item> inv { get { return Inv; } }
        public virtual List<Item> Inv { get; set; }
        // Returns true if item exists in inventory, false if not
        public bool IsLocated(string item) { return Inv.Exists(x => x.Title.Equals(item.ToUpper())); }
        // Checks inventory to see if item already exists. Is so, add to the quantity, else create the new item
        public void AddItem(Item i)
        {
            if (IsLocated(i.Title))
                GetItem(i.Title).Qnt++;
            else
                Create(i);
        }
        // Checks inventory to see if item has a quantity greater than 1. Is so, remove from the quantity, else delete the item entirely
        public void RemoveItem(string item)
        {
            if (MyQnt(item) > 1)
                GetItem(item).Qnt--;
            else
                Delete(item);
        }

        public Item CopyItem(string item) { return new Item(item.ToUpper(), GetItem(item).Desc, 
            GetItem(item).Qnt, GetItem(item).Weight); }
      
        // Returns true if new item wont exceed Carryweight, false if it does
        public bool CanCarry(string item)
        {
            int totalWeight = 0;
            if (Inv.Count.Equals(0)) return true;
            foreach (Item x in Inv) totalWeight += x.Weight;
            if (totalWeight + GetItem(item).Weight <= 10) return true;
            return false;
        }

        public void PrintDesc(string item) { Console.WriteLine(GetItem(item).Desc); }
        public void PrintInv() { foreach (Item x in Inv) Console.WriteLine(x.Title); }
      
        



/*************************************************************************************************************************
* PRIVATE METHODS FOR LOW LEVEL IMPLEMENTATION
/*************************************************************************************************************************/
        // Returns item in inventory
        private Item GetItem(string item) { return Inv.Find(x => x.Title.Equals(item.ToUpper())); }
        // Returns quantity of item in inventory
        private int MyQnt(string item) { return GetItem(item).Qnt; }
        // Creates an new instatiation of a given item
        private void Create(Item i)
        {
            i.Qnt = 1;
            Inv.Add(i);
        }
        // Deletes a given Item
        private void Delete(string item) { Inv.Remove(GetItem(item)); }
        
    }
}
