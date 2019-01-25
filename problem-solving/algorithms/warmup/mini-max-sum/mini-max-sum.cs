/* 
 NOTE: This is probably not the best solution. Ideally you should use LINQ Max and Sum functions to solve this puzzle. Refer to python solution for the same.
*/

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

        long[] sumArray = new long[5];

        long firstElement = arr.First();
        if (arr.All(x => x == firstElement))
        {
            Console.WriteLine(firstElement * 4 + " " + firstElement * 4);
        }
        else
        {
            for (long i = 0; i < arr.Length; i++)
            {
                sumArray[i] = arr.Except(new long[] { arr[i] }).Sum();
            }
            Console.WriteLine(sumArray.Min() + " " + sumArray.Max());
        }

    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        miniMaxSum(arr);
    }
}

