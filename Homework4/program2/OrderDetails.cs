using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderDetails
    {
        public OrderDetails(string name,int nu,int price)
        {
            this.name = name;
            this.Nu = nu;
            this.price = price;
        }
        string name;
        public string Name
        {
            get
            {
               return name;
            }
        }
        public int Nu { get; set; }
        int price;
        public int EachPrice
        {
            get
            {
                return price;
            }
        }
        public int Price
        {
            get
            {
                return EachPrice * Nu;
            }
        }

    }
}
