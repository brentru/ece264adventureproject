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
    class Item
    {
        //declare class variables
        private string title;
        private string desc;
        private int qnt;
        private int weight;

        //initialize constructors
        public string Title { get { return title; } set { title = value; } }
<<<<<<< HEAD

        public string Desc { get { return desc; } set { desc = value; } }

        public int Qnt { get { return qnt; } set { qnt = value; } }

=======
        public string Desc { get { return desc; } set { desc = value; } }
        public int Qnt { get { return qnt; } set { qnt = value; } }
>>>>>>> pr/4
        public int Weight { get { return weight; } set { weight = value; } }

        public Item() { Title = ""; Desc = ""; Qnt = 0; Weight = 0; }
        public Item(string ttl, string des, int q, int w)
        {
            Title = ttl;
            Desc = des;
            Qnt = q;
            Weight = w;

        }

<<<<<<< HEAD
    }
}
=======


    }
}
>>>>>>> pr/4
