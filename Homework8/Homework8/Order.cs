using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace project1
{
    [Serializable]
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderDetailNu, string name, int orderNu)
        {
            orderDetails = new OrderDetails[orderDetailNu];
            this.Name = name;
            this.OrderNu = orderNu;
            this.serialNumber = System.DateTime.Now.ToShortDateString();
            if (orderNu < 10)
            {
                this.serialNumber = this.serialNumber + '0' + '0' + orderNu.ToString();
            } else if (orderNu < 100)
            {
                this.serialNumber = this.serialNumber + '0' + orderNu.ToString();
            } else
            {
                this.serialNumber = this.serialNumber + orderNu.ToString();
            }
            int count = 0;
            foreach (char a in this.serialNumber)
            {
                if (a == '/')
                {
                    this.serialNumber = this.serialNumber.Remove(count, 1);
                    count--;
                }
                count++;
            }
        }

        public string serialNumber;
        public string Name { get; set; }
        public string SerialNumber
        {
            get
            {
                return this.serialNumber;
            }
        }
        public int OrderNu { get; set; }

        public string TellNu{get; set;}
        public OrderDetails[] orderDetails;
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
