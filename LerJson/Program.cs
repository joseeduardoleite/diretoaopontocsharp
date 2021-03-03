using System;
using System.IO;
// using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Json.Net;
// using System.Text.Json;


namespace LerJson
{
    class Program
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            var json = File.ReadAllText("user.json");
            Console.WriteLine(json);
            
            User usuario = new User() {Name = "du", Age = 20, Email = "du@gft.com"};
        

            json = JsonNet.Serialize(usuario);
            usuario = JsonNet.Deserialize<User>(json);

            // Console.WriteLine(usuario.Name);
            // Console.WriteLine(usuario.Age);
            // Console.WriteLine(usuario.Email);

            File.WriteAllText("user.json", json);
        }
    }
}
