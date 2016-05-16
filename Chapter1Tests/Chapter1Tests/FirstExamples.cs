using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1Tests
{
    public class FirstExamples
    {
        public void FirstExampleSet()
        {
            var names = new List<string>()
            {
                "Tom",
                "Dick",
                "Harry",
                "Mary",
                "Jay",
                "Rick",
                "Chris",
                "Tyra",
                "Mike",
                "Diane",
                "Richard",
                "Virginia"
            };

            var shortNames = names.Where(n => n.Length <= 4);
            var filteredNames = names.Where(n => n.Length > 4);
            var sortedNames = filteredNames.OrderBy(n => n);

            Console.WriteLine("Query tests on Names");
            Console.WriteLine("--------------------");

            foreach (var word in shortNames)
                Console.WriteLine($"ShortNames: {word}");

            Console.WriteLine();

            foreach (var word in filteredNames)
                Console.WriteLine($"Name: {word}");

            Console.WriteLine();

            foreach (var word in sortedNames)
                Console.WriteLine($"Name: {word}");
            Console.ReadKey();
        }
    }
}