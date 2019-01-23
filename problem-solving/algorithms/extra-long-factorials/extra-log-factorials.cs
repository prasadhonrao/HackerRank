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

    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n) {
        System.Numerics.BigInteger factorial = 1;

        while (n > 0)
        {
            factorial = factorial * n;
            n--;
        }
        Console.WriteLine(factorial);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}
