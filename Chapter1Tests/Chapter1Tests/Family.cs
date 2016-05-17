using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1Tests
{
    public class Family : People
    {
        public DateTime BirthDate { get; set; }

        public static void ShortFamilyNames(IEnumerable<Family> familyMembers)
        {
            var shortNames = from n in familyMembers
                where n.FirstsName.Length == 4
                select n;

            foreach (var name in shortNames)
                Console.WriteLine($"Name: {name.FirstsName} {name.LastName},\tDOB: {name.BirthDate:D}");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void BornBefore1962(IEnumerable<Family> familyMembers)
        {
            var query = from n in familyMembers
                where n.BirthDate.Year < 1962
                select n;

            foreach (var member in query)
                Console.WriteLine($"Name: {member.FirstsName} {member.LastName},\tDOB: {member.BirthDate:D}");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void FamilyOrderedList(IEnumerable<Family> familyMembers)
        {
            var orderedList = from names in familyMembers
                orderby names.BirthDate
                select names;

            foreach (var member in orderedList)
                Console.WriteLine($"Name: {member.FirstsName} {member.LastName},\tDOB: {member.BirthDate:D}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}