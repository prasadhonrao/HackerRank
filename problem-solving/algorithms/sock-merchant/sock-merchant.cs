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

    static int sockMerchant(int n, int[] ar) {
        var groups = ar.Take(n).GroupBy(x => x);
        int total = 0;
        foreach (var group in groups)
        {
            var count = group.Count();
            total += count / 2;
        }
        return total;
    }

    static void Main(string[] args) {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
        // textWriter.WriteLine(result);
        // textWriter.Flush();
        // textWriter.Close();
    }
}
