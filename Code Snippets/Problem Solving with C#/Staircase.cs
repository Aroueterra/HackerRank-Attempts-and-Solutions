//Staircase
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

    // Complete the staircase function below.
    static void staircase(int n) {
        var stair = new List<List<string>>();

        for(int i = 0; i < n; i++){
            var step = new List<string>();
            for(int j = 0; j < n; j++){
                if(j < n-(i+1) && n-(i+1) >= 1){
                   step.Add(" ");
                }else{
                   step.Add("#");                }
            }
            stair.Add(step);
        }
        foreach(var step in stair){
            foreach (var value in step)
            {
                Console.Write(value);
            }
            Console.WriteLine();
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
