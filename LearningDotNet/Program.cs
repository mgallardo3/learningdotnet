using System;
using System.Collections.Generic;

namespace LearningDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> costumers = new List<string>();

            costumers.Add("Kim");
            costumers.Add("Leo");
            costumers.Add("Lima");

            Console.WriteLine(costumers.Count);
            foreach (var costumer in costumers)
            {
                Console.WriteLine(costumer);
            }

            Dictionary<string, string> config = new Dictionary<string, string>();
            config.Add("resolution", "23458kjhg0987");
            config.Add("title", "f84epdyis");

            Console.WriteLine(config["title"]);
        }
    }
}
