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
            //JsonFile();
            RdFile();
        }

        public static void RdFile()
                    {
                    string filePath1 = "files/lesson-W5.json";
                    string filePath2 = "files/lesson-w5-updated.json";
                    string readFile = "";
                    string writeFile = "";
            Printers print = new 



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
        

 