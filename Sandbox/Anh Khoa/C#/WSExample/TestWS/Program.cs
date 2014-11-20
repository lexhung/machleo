using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestWS
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            var json = wc.DownloadString("http://localhost:1120/api/values/");

            var parsedData = JsonConvert.DeserializeObject<Person>(json);
        }
    }
}
