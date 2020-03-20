using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(NewsFeed.FeedService)))
            {
                host.Open();
                Console.WriteLine("Host has started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
