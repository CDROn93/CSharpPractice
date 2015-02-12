using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Threading.Tasks;

namespace Threads
{
    class Threads
    {
        static void Main(string[] args)
        {
            DownloadAsynchronously();
            Console.WriteLine("Waiting to finish on thread {0}...",Thread.CurrentThread.ManagedThreadId);
        }
        private static void DownloadAsynchronously()
        {
            string[] urls = { "http://www.microsoft.com/en-us/default.aspx",
                              "http://twitter.com/odetocode",
                            "http://www.pluralsight.com/courses/csharp-fundamentals"};
          //  foreach (var url in urls) //not the easiest way to use threads 
            //{
              //  var thread = new Thread(Download);
                //thread.Start(url);
            //}
            //foreach (var url in urls)
            //{
              //  Download(url);
            //}
            //best way to do it
            Parallel.ForEach(urls, url =>
                                       {
                                           var client = new WebClient();
                                           var html = client.DownloadString(url.ToString());
                                           Console.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);
                                           //Console.WriteLine(html.ToString());
                                       });
        }
        private static void Download(String url) //needs to be object to do multithreading... 
        {
           // var client = new WebClient();
            //var html = client.DownloadString(url.ToString());
            //Console.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);

            var client = new WebClient();
            client.DownloadDataCompleted += client_DownloadDataCompleted;
            client.DownloadStringAsync(new Uri(url),url);
            
        }

        static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            var html = e.Result;
            var url = e.UserState as string;
            Console.WriteLine("Download {0} chars from {1} on thread {2}", html.Length, url, Thread.CurrentThread.ManagedThreadId);
        }

    }
}
