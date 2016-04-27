using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace xmltest
{
    // item class/list structure
    public class Item
    {
        public string itemTitle { get; set; }
        public string itemDesc { get; set; }
        public int itemQnt { get; set; }
        public int itemWeight { get; set; }
    }
    // character class/list structure
    public class Character
    {
        public string charName {get; set;}
        public int charPosition {get; set;}
        public int charWeight { get; set; }
    }

    class Program
    {
        // declare lists
        public static List<Character> charList;
        public static List<Item> itemList;

        static void Main(string[] args)
        {
            // creating itemList from xml
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


            // creating charList from xml
            charList = (
                   from e in XDocument.Load("C:/Users/brent/Desktop/charimport.xml").
                             Root.Elements("chardata")
                   select new Character
                   {
                       charName = (string)e.Element("name"),
                       charPosition = (int)e.Element("position"),
                       charWeight = (int)e.Element("weight"),
                   })
                   .ToList(); // make the entire select new map + array a list

            Console.Read(); // put dbg point here
        }
    }
}


