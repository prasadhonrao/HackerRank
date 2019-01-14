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

    // Complete the utopianTree function below.
    static int utopianTree(int item) {
        int defaultHeight = 1;
        if (item == 0)
        {
            return defaultHeight;
        }
        else
        {
            bool doubled = false;
            for (int i = 1; i <= item; i++)
            {
                if (!doubled)
                {
                    defaultHeight = defaultHeight * 2;
                    doubled = true;
                }
                else
                {
                    defaultHeight = defaultHeight + 1;
                    doubled = false;
                }
            }

            return defaultHeight;
        }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
