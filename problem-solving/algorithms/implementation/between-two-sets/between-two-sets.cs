using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int getTotalX(int[] a, int[] b)
    {
        var lcm = LCM(a);
        var gcf = GCF(b);

        var candidate = lcm;
        var count = 0;
        while (candidate <= gcf)
        {
            count += gcf % candidate == 0 ? 1 : 0;
            candidate += lcm;
        }
        return count;
    }

    static int LCM(int[] x) => x.Aggregate(lCM);
    static int GCF(int[] x) => x.Aggregate(gCF);
    static int gCF(int a, int b) => b == 0 ? a : gCF(b, a % b);
    static int lCM(int a, int b) => (a * b) / gCF(a, b);

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
