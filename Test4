using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = @"It was the best of times,
                        it was the worst of times,
                        it was the age of wisdom,
                        it was the age of foolishness,";

        string[] lines = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, HashSet<int>> wordLines = new Dictionary<string, HashSet<int>>();

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i].ToLower();
            string[] words = line.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' },                                 StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (!wordLines.ContainsKey(word))
                    wordLines[word] = new HashSet<int>();

                wordLines[word].Add(i + 1);
            }
        }

        foreach (var entry in wordLines.OrderBy(e => e.Key))
        {
            string word = entry.Key;
            var linesSet = entry.Value.OrderBy(n => n).ToList();
            string lineNumbers = string.Join("-", new int[] { linesSet.First(), linesSet.Last() }.Distinct());

            Console.WriteLine($"{word} {lineNumbers}");
        }
    }
}
