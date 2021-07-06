using Newtonsoft.Json;
using SampleLib;
using System;

namespace DemoSourceLink
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User() { Name = "Bourne" , Age = 29};
            var json = JsonConvert.SerializeObject(user); //press F11 on this line and verify it could load symbol
            Console.WriteLine(json);

            var student = new Student("bourne"); //load symbol
            Console.WriteLine(student);
        }
    }
}
