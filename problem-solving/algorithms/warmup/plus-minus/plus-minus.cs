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

    static void plusMinus(int[] arr) {
        int n = arr.Length;
        int positives = arr.Where(x => x > 0).Count();
        int negatives = arr.Where(x => x < 0).Count();
        int zeroes = arr.Where(x => x == 0).Count();
        
        float positiveFraction = (float)positives / (float)n;
        float negativeFraction = (float)negatives / (float)n;
        float zeroFraction = (float)zeroes / (float)n;
        
        Console.WriteLine(positiveFraction);
        Console.WriteLine(negativeFraction);
        Console.WriteLine(zeroFraction);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}