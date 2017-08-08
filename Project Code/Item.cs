using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure

{
    class Item
    {
        private string title;
        private string desc;
        private int qnt;
        private int weight;

        public string Title { get { return title; } set { title = value; } }

        public int Weight { get { return weight; } set { weight = value; } }

        public Item() { Title = ""; Desc = ""; Qnt = 0; Weight = 0; }
        public Item(string ttl, string des, int q, int w)
        {
            Title = ttl;
            Desc = des;
            Qnt = q;
            Weight = w;
        }

    }
}
