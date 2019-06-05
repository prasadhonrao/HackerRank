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
    static int[] breakingRecords(int[] scores, int n) {
        var min = scores[0];
        var max = scores[0];
        var c1 = 0;
        var c2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (scores[i] > max) {
                c1+=1;
                max=scores[i];
            }
            if (scores[i] < min) {
                c2+=1;
                min=scores[i];
            }
        }
        return new int[] {c1, c2};
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores, n);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
