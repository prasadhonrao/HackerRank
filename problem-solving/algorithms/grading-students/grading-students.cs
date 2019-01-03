using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] gradingStudents(int[] grades)
    {
        int length = grades.Length;
        int[] revisedGrade = new int[length];

        for (int i = 0; i < grades.Length; i++)
        {
            revisedGrade[i] = GetNewGrade(grades[i]);
        }

        return revisedGrade;
    }

    private static int GetNewGrade(int grade)
    {
        if (grade < 38 || grade % 5 == 0)
        {
            return grade;
        }

        int newGrade = 0;

        int remainder = grade / 5;
        newGrade = (remainder + 1) * 5;

        if (newGrade - grade < 3)
        {
            return newGrade;
        }
        else if (newGrade - grade == 3)
        {
            return grade;
        }
        else
        {
            return grade;
        }
    }

    static void Main(string[] args) {
        // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        Console.WriteLine(string.Join("\n", result));

        // tw.WriteLine(string.Join("\n", result));

        // tw.Flush();
        // tw.Close();
    }
}
