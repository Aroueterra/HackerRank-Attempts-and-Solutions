//Plus-Minus Precision
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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        List<float> posi = new List<float>(),nega = new List<float>(),zero = new List<float>();
        foreach(int n in arr){
            if(n>0){
                posi.Add(n);
            }else if (n==0){
                zero.Add(n);
            }else{
                nega.Add(n);
            }
        }
        var total = arr.Count();
        float p = (float)posi.Count() / (float)total;
        float z = (float)zero.Count() / (float)total;
        float ne = (float)nega.Count() / (float)total; 
        Console.WriteLine("{0:F6}",p);
        Console.WriteLine("{0:F6}",ne);
        Console.WriteLine("{0:F6}",z);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
