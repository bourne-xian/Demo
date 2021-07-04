using Newtonsoft.Json;
using System;

namespace DemoSourceLink
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User() { Name = "Bourne" , Age = 29};
            var json = JsonConvert.SerializeObject(user);
            Console.WriteLine(json);
        }
    }
}
