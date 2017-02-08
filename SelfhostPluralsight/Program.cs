using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;
using System.Web.Http;

namespace SelfhostPluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration("http://localhost:7777");
            config.Routes.MapHttpRoute("default",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            var server = new HttpSelfHostServer(config);
            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Server up and running..");
            Console.ReadLine();

        }
    }
}
