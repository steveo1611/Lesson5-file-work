// Program to retrieve the following data:
// Replace the IP address of the device for which hostname is 'HP2D0DB0' to '15.13.19.22'
// print the updated value
// Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
// this data will be extracted from xml file in the files folder.

using System;
using System.IO;

namespace Lesson5_file_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Heaven!");
            JFile();
        }
    }

    public class JFile
    {
        using (StreamReader r = new StreamReader("./files/lesson-W5.json"))
        {
    
        }
    }

    public class Item
    {
        public int localDeviceId;
        public string hostName;
        public string ipAddress;
        public string modelName;
        public string serialNumber;
        public string ocvStatus;
    }

}
 