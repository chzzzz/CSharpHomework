using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace project1
{
    public class OrderDetails
    {
        public OrderDetails()
        {

        }
        public OrderDetails(string name,int nu,int price)
        {
            this.Name = name;
            this.Nu = nu;
            this.EachPrice = price;
            Id = Guid.NewGuid().ToString();
        }
        public string Name
        {
            get;
            set;
            
        }
        public int Nu { get; set; }
        public int EachPrice
        {
            get;
            set;
           
        }
        public int Price
        {
            get
            {
                return EachPrice * Nu;
            }
        }
        [Key]
        public string Id { get; set; }
    }
}
