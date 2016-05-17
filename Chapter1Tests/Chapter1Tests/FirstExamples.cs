using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1Tests
{
    public class FirstExamples
    {
        public static void OrderedList(IList<RandomPeople> people)
        {
            var orderedList = from names in people
                orderby names.FirstName
                select names;

            foreach (var name in orderedList)
                Console.WriteLine($"Name: {name.FirstName}");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void FilteredNames(IList<RandomPeople> people)
        {
            var filteredNames = from names in people
                where names.FirstName.Length > 4
                select names;

            foreach (var name in filteredNames)
                Console.WriteLine($"Name: {name.FirstName}");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ShortNames(IList<RandomPeople> people)
        {
            var shorNames = from names in people
                where names.FirstName.Length <= 4
                select names;

            foreach (var name in shorNames)
                Console.WriteLine($"Name: {name.FirstName}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}