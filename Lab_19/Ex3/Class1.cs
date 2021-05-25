using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    [Serializable]
    class Storage
    {
        public string name;
        public int price, count;
        public Storage( string name , int price , int count)
        {
            this.name = name;
            this.count = count;
            this.price = price;
        }


    }
}
