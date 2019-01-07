
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


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}

// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// class Solution {

//     static void Main(String[] args) {
//         int n = Convert.ToInt32(Console.ReadLine());
//         string[] arr_temp = Console.ReadLine().Split(' ');
//         int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
//         int positives = arr.Where(x => x > 0).Count();
//         int negatives = arr.Where(x => x < 0).Count();
//         int zeroes = arr.Where(x => x == 0).Count();
        
//         float positiveFraction = (float)positives / (float)n;
//         float negativeFraction = (float)negatives / (float)n;
//         float zeroFraction = (float)zeroes / (float)n;
        
//         Console.WriteLine(positiveFraction);
//         Console.WriteLine(negativeFraction);
//         Console.WriteLine(zeroFraction);
//     }
// }
