using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler crawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            crawler.urls.Add(startUrl, false);
            crawler.Crawl();
        }
    }
}
