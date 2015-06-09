using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Enumerator>();
            Console.WriteLine("Enter path to file");
            var inputFile = Console.ReadLine();

            Console.WriteLine("Enter path to save file");
            var outputFile = Console.ReadLine();

            var lineVal = 1;

            foreach (var line in File.ReadLines(inputFile, Encoding.Default))
            {
                var dictionary = Regex.Matches(line, @"[a-bа-яё]+").OfType<Match>().Select(m => m.Value.ToLower());
                foreach (var wordValue in dictionary)
                {
                    Enumerator enumerator;
                    if (!result.TryGetValue(wordValue, out enumerator))
                        enumerator = result[wordValue] = new Enumerator();
                    enumerator.Enumerate++;
                    enumerator.Lines.Add(lineVal);
                }
                lineVal++;
            }

            using (var sw = new StreamWriter(outputFile))
                foreach (var pair in result.OrderBy(p => p.Key))
                {
                    sw.WriteLine("{0}{1}: {2}", pair.Key.PadRight(20, '.'), pair.Value.Enumerate, string.Join(",", pair.Value.Lines.OrderBy(l => l)));
                }
        }
    }
}
