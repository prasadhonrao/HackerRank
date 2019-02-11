using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string input = Console.ReadLine();
        var count = input.Where(c => c >= 'A' && c <= 'Z').Count();
        Console.WriteLine(count + 1);
    }
}
