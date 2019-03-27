// Program to retrieve the following data:
// Replace the IP address of the device for which hostname is 'HP2D0DB0' to '15.13.19.22'
// print the updated value
// Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
// this data will be extracted from json file in the files folder.

using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;

namespace Lesson5_file_work
{
    class Program
    {
        static void Main(string[] args)
        {
           RdFile();
        }

        public static void RdFile()
        {
            //string filePath1 = "files/lesson-W5.json";
             string filePath1 = "D:\\projects\\source\\file\\lesson-W5.json";
             string filePath2 = "D:\\projects\\source\\file\\lesson-w5-updated.json";

            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(filePath1));
            DataTable dataTable = dataSet.Tables["results"];
            int colCount = dataTable.Columns.Count;

            foreach (DataRow row in dataTable.Rows)
            {
                object hn = row["hostName"];
                string file = (string)hn;

                // If true change IP for this object to '15.13.19.22'
                if (file.Contains("HP2D0DB0"))
                {
                    Console.WriteLine("Original IPAddress: " + row["ipAddress"]);
                    row["ipAddress"] = "15.13.19.22";
                    Console.WriteLine("Updated IPAddress: " + row["ipAddress"]);
                }
                else
                {
                    // could do a if/for loop to count how many times this is hit and if equals count trigger console message
                    //  Console.WriteLine("HostName Not found");
                }
            }
            // another search through dataset to find the ocvstatus details and print it
            Console.WriteLine(); //  adds line between sections that are output

            // Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
            foreach (DataRow row2 in dataTable.Rows)
            {
                object ocvStat = row2["ocvStatus"];
                string ovc = (string)ocvStat;

                if (ovc.Contains("GenuineHP"))
                {
                    for (var i = 0; i < colCount; i++)
                        Console.WriteLine(dataTable.Columns[i].ColumnName + ": " + row2[i]);
                }
                else
                {
                    //  same as above: for generating an error type message
                    //  Console.WriteLine("No Printers have GenuineHP ocvStatus");
                }
            }
            // Save updated json file to new json file (so I can test multiple times)
            Console.WriteLine();
            Console.WriteLine("Saving updated file to " + filePath2);
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            File.WriteAllText(filePath2, json);
            Console.ReadKey();
        }
    }
}
