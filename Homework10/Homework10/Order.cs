using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace project1
{
    [Serializable]
    public class Order
    {
        
        public Order()
        {

        }
        public Order( string name, int orderNu,string serialNumber)
        {
            
            this.Name = name;
            this.OrderNu = orderNu;
            this.SerialNumber = serialNumber;
            OrderDetails = new List<OrderDetails>();
        }

        
        public string Name { get; set; }
        public string SerialNumber
        {
            get;
            set;
        }
        [Key]
        public int OrderNu { get; set; }

        public string TellNu{get; set;}
        public List<OrderDetails> OrderDetails
        { get; set; }

        public bool JudgeSerialNu(string s)
        {
            DateTime time = System.DateTime.Now;
            string pattern = "^" +
                time.Year.ToString() + 
                time.Month.ToString() + 
                time.Day.ToString()+
                "[0-9]{3}$"
                ;
            if (Regex.IsMatch(s, pattern)) return true;
            else return false; 
        }

    }
}
