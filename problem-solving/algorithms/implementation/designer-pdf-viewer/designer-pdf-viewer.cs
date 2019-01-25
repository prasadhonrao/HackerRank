using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

   // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] numbers, string word) {
        var wordArray = word.ToCharArray();
        char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            dict[alphabet[i]] = numbers[i];
        }

        var max = 0;

        for (int i = 0; i < wordArray.Length; i++)
        {
            if (dict.ContainsKey(word[i]))
            {
                int val = dict[wordArray[i]];
                if (val > max)
                    max = val;
            }
        }

        return (word.Length * max);
    }

    static void Main(String[] args) {
        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
