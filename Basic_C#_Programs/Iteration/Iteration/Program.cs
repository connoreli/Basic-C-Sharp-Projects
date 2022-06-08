using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[] testscores = { 99, 98, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testscores.Length; i++)
        {
            if (testscores[i] > 85)
            {
                Console.WriteLine("passing test score: " + testscores[i]);
            }
        }
        Console.ReadLine();


        string[] names = { "connor", "dallin", "cody", "haley" };

        for (int n = 0; n < names.Length; n++)
        {
            if (names[n] == "connor")
            {
                Console.WriteLine(names[n]);
            }
        }
        Console.ReadLine();

        List<int> testscores1 = new List<int>();
        testscores1.Add(98);
        testscores1.Add(99);
        testscores1.Add(81);
        testscores1.Add(72);
        testscores1.Add(70);

        foreach (int score in testscores1)
        {
            if (score > 85)
            {
                Console.WriteLine("passing test score:" + score);
            }
        }
        Console.ReadLine();

        List<string> names1 = new list<string>() { "connor", "olivia", "dallin", "haley" };

        foreach (string name in names1)
        {
            console.writeline(name);
        }
        console.readline();

        List<int> testScores2 = new List<int>() { 98, 99, 12, 72, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores2)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}
