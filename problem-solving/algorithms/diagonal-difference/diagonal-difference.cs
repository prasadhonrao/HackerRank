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

    static int diagonalDifference(int[][] arr) {
        int primary = 0;
        int secondary = 0;

        for (int i = 0; i < n; i++)
        {
            primary += arr[i][i];
        }

        for (int j = 0; j < a.Length; j++)
        {
            secondary += arr[j][n - 1];
            n--;
        }

        return Math.Abs(primary - secondary);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
