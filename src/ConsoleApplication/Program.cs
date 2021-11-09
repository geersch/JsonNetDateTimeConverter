using System;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            // Read JSON data
            var json = File.ReadAllText("json.txt");
            Console.WriteLine(json);
            Console.WriteLine();

            // Deserialize JSON into ReputationChange object                        
            var reputation = JsonConvert.DeserializeObject<ReputationChange>(json);
            Console.WriteLine(reputation.OnDate);
            Console.WriteLine();

            // Serialize ReputationChange object back into JSON
            json = JsonConvert.SerializeObject(reputation);
            Console.WriteLine(json);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }  
}
