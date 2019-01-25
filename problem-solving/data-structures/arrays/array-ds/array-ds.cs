using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr_temp = Console.ReadLine().Split(' ');

        int[] arr = Array.ConvertAll(arr_temp.Take(n).ToArray(), Int32.Parse);

        var reverse = arr.Reverse();
        foreach (var item in reverse)
        {
            Console.Write(item + " ");
        }
    }
}
