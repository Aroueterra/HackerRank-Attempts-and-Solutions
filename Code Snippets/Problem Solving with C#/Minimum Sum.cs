//Minimum Sum
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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long min = 0, max = 0, total = arr.Count();
        Array.Sort(arr);
        for(int i = 0; i < total; i++){
            if(i<4){
            min+=arr[i];
            max+=arr[(total-1)-i];
            }else{
                break;
            }
        }
        Console.WriteLine("{0} {1}", min, max);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
