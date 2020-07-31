using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        List<string> time = new List<string>();
        // s = "12:40:22AM";
        string quarter = s.Substring(s.Length - 2);
        s = s.Replace(quarter, String.Empty);
        time = s.Trim().Split(':').ToList();
        if(Convert.ToInt32(time[0]) < 12){
            time[0] = (Convert.ToInt32(time[0])+12).ToString();
        }else if (Convert.ToInt32(time[0]) >= 12){
            time[0] = (Convert.ToInt32(time[0])-12).ToString();
            Console.WriteLine(time[0].Length);
            if (time[0].Length == 1){
                time[0] = "0" + time[0];
            }
         }
        Console.WriteLine(String.Join(":", time));
        return String.Join(":", time);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
