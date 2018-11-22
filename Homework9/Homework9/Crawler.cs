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
    class Crawler
    {

        private Hashtable urls = new Hashtable();
        private int count = 0;
        private void Crawl()
        {
            Console.WriteLine("开始爬行了...........");
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    string count = url;
                    break;
                }
                if (count > 10 || current == null) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = Download(current);
                urls[current] = true;
                count++;
            }
            Console.WriteLine("结束");
        }
        public string Download(string url)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string pageHtml = client.DownloadString(url);
            File.WriteAllText(count.ToString(), pageHtml, Encoding.UTF8);
            return pageHtml;
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef =match.Value.Substring(match.Value.IndexOf("=")+1).Trim(new char[]{'"','\"','#','>'});
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
        static void main(string [] args)
        {
            Crawler crawler = new Crawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            crawler.urls.Add(startUrl, false);
            new Thread(crawler.Crawl).Start();
        }
    }
}
