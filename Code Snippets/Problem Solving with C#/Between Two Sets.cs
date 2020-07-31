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

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    static long LCM(long[] numbers)
    {
        return numbers.Aggregate(lcm);
    }
    static long GCD(long[] numbers)
    {
        return numbers.Aggregate(gcd);
    }
    static long lcm(long a, long b)
    {
        return Math.Abs(a * b) / gcd(a, b);
    }
    static long gcd(long a, long b)
    {
        return b == 0 ? a : gcd(b, a % b);
    }
    public static int GCF(int a, int b)
    {    
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int getTotalX(List<int> a, List<int> b)
    {
        var longer = a.Select(i => (long)i).ToArray();
        var longerb = b.Select(i => (long)i).ToArray();
        var lcm = LCM(longer);
        var gcd = GCD(longerb);
        int result = 0;
        for(long i = lcm; i <= gcd; i++){
            if((gcd % i == 0) && (i % lcm == 0)){
                result++;
            }
        }
        Console.WriteLine(result);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
