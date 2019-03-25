// Program to retrieve the following data:
// Replace the IP address of the device for which hostname is 'HP2D0DB0' to '15.13.19.22'
// print the updated value
// Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
// this data will be extracted from json file in the files folder.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson5_file_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Heaven!");
            JsonFile();
       //     RdFile();
        }
        /*        public static void RdFile()
                    {
                    string filePath1 = "files/lesson-W5.json";
                    string filePath2 = "files/lesson-w5-updated.json";
                    //           string[] readFile = new string[jobj];
                    string readFile = "";
                    string writeFile = "";
          //          using (StreamReader r = new StreamReader(filePath1))
                    using (StreamReader r = File.OpenText(filePath1))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Printers printer = (Printers)serializer.Deserialize(r);
           //             Printers printer = (Printers)serializer.Deserialize(r, typeof(Printers));

                        var line = r.ReadToEnd();
                  //      dynamic jobj = JObject.Parse(line);
                        dynamic jobj = JObject.FromObject(line);
                        readFile = jobj.ToString();
        //                List<Printers> printer = JsonConvert.DeserializeObject<List<Printers>> (jobj);
        //               List<Printers> printer = new List<Printers>(jobj);


                        //               var jobj = JObject.Parse(line);
                        //             readFile = jobj.ToString();
                        //               foreach (var item in line)
                        Console.WriteLine(jobj);
                        {
                            //                   if (item == )

                            foreach (var item in printer)
                            {
                                Console.WriteLine(item);
                                Console.ReadKey();
                            }
                            }

                    }
                    }
             public class Printers
                {
                    public int localDeviceId { get; set; }
                    public string hostName { get; set; }
                    public string ipAddress { get; set; }
                    public string modelName { get; set; }
                    public string serialNumber { get; set; }
                    public string ocvStatus { get; set; }
                }



                }
            }
        */


        public static object JsonFile()
        {
            using (StreamReader r = new StreamReader("./files/lesson-W5.json"))
            {
                string line = r.ReadToEnd();
             //   object readFile = "";
                Items item = new Items();
                //List<Items> item = JsonConvert.DeserializeObject<List<Items>>(line);
                JsonConvert.PopulateObject(line, item);
                return item;
            }
        }

        public class Items
        {
            public int localDeviceId { get; set; }
            public string hostName { get; set; }
            public string ipAddress { get; set; }
            public string modelName { get; set; }
            public string serialNumber { get; set; }
            public string ocvStatus { get; set; }
        }


    }
}
 