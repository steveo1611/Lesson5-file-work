// Program to retrieve the following data:
// Replace the IP address of the device for which hostname is 'HP2D0DB0' to '15.13.19.22'
// print the updated value
// Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
// this data will be extracted from json file in the files folder.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Lesson5_file_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Heaven!");
            RdFile();
        }

        public static void RdFile()
        {
            string filePath1 = "files/lesson-W5.json";
            // string filePath1 = "D:\\projects\\source\\file\\lesson-W5.json";
            string filePath2 = "D:\\projects\\source\\file\\lesson-w5-updated.json";

            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(filePath1));
            DataTable dataTable = dataSet.Tables["results"];

            foreach (DataRow row in dataTable.Rows)
            {
                object hn = row["hostName"];
                string file = (string)hn;

                if (file.Contains("HP2D0DB0"))
                {
                    // If true change IP for this object to '15.13.19.22'
                    Console.WriteLine(row["ipAddress"]);
                    row["ipAddress"] = "15.13.19.22";
                    Console.WriteLine(row["ipAddress"]);
                    // loop through object to display?? or use foreach?  for (i > 0;row.len i++; )
                }
                else
                {
                    Console.WriteLine("Losser");
                }
                foreach (DataRow row2 in dataTable.Rows)
                {
                    // Get the list of the device's ocvStatus and verify if it contains 'GenuineHP'
                    object ocvStat = row2["ocvStatus"];
                    string ovc = (string)ocvStat;



                    if (ovc.Contains("GenuineHP"))
                    {
                        Console.WriteLine("WINNER");
                    }

                    Console.WriteLine("Losser");
                    Console.ReadKey();

                }
            }
        }
    }
}

/*  Deserialize JSON =======================================

string json = @"{
  'Name': 'Bad Boys',
  'ReleaseDate': '1995-4-7T00:00:00',
  'Genres': [
    'Action',
    'Comedy'
  ]
}";

Movie m = JsonConvert.DeserializeObject<Movie>(json);

string name = m.Name;
// Bad Boys

    */

 /* Linq to JSON.....==================================
JArray array = new JArray();
array.Add("Manual text");
array.Add(new DateTime(2000, 5, 23));

JObject o = new JObject();
o["MyArray"] = array;

string json = o.ToString();
// {
//   "MyArray": [
//     "Manual text",
//     "2000-05-23T00:00:00"
//   ]
// }

    */