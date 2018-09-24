using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Graph
    {
        protected double[] length = new double[3] { 1, 1, 1 };
        public double Length1
        {
            set
            {
                if (value >= 1)
                {
                    length[0] = value;
                }
                else
                {
                    Console.WriteLine("最小长度为1");
                }

            }
            get
            {
                return length[0];
            }
        }
        public double Length2
        {
            set
            {
                if (value >= 1)
                {
                    length[1] = value;
                }
                else
                {
                    Console.WriteLine("最小长度为1");
                }

            }
            get
            {
                return length[1];
            }
        }
        public double Length3
        {
            set
            {
                if (value >= 1)
                {
                    length[2] = value;
                }
                else
                {
                    Console.WriteLine("最小长度为1");
                }

            }
            get
            {
                return length[2];
            }
        }
        public virtual void OutPutArea()
        {
            
        }
        public virtual void Earse()
        {
            System.Console.Clear();
        }
    }
}
