using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class GraphFactory
    {
       public static Graph CreatGraph(string name)
        {
            Graph graph = null;
            switch(name)
            {
                case "Cirle":
                    graph = new Cirle();
                    break;
                case "Triangle":
                    graph = new Triangle();
                    break;
                case "Square":
                    graph = new Square();
                    break;
                case "Rectangle":
                    graph = new Rectangle();
                    break;
            }
            return graph;
        }
    }
}
