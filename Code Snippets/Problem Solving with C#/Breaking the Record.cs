//Breaking the Record
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        int best = 0, worst = 0, update1 = 0, update2 = 0, count = 0;
        List<int> list = new List<int>();
        
        foreach(var score in scores){
            if(count == 0){
                best = score;
                worst = score;
                count++;
            }
            if(score > best){
                best = score;
                update1++;
            }
            if(score < worst){
                worst = score;
                update2++;
            }
        }
        int[] result = { update1, update2 };
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
