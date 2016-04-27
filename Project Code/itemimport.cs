using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * from uml
 * 
   private string title;
   private string desc;
   private int qnt;
   private int weight;
*/

namespace xmltest
{
    // map class, built from <mapdata>
    public class Item
    {
        public string itemTitle { get; set; }
        public string itemDesc { get; set; }
        public int itemQnt { get; set; }
        public int itemWeight { get; set; }
    }
    class Program
    {
        // list decl
        public static List<Item> itemList;
        static void Main(string[] args)
        {
            // loading xml, data selected is within the <mapdata> set
            itemList = (
                    from e in XDocument.Load("C:/Users/brent/Desktop/itemimport.xml").
                              Root.Elements("itemdata")
                    select new Item
                    {
                        itemTitle = (string)e.Element("title"),
                        itemDesc = (string)e.Element("desc"),
                        itemQnt = (int)e.Element("qnt"),
                        itemWeight = (int)e.Element("weight"),
                    })
                    .ToList(); // make the entire select new map + array a list

            // put dbg point here
            Console.Read();
        }
    }
}


