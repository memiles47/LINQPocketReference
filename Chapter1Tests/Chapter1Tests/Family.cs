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
                Console.WriteLine($"Name: {name.FirstsName} {name.LastName}, DOB: {name.BirthDate:D}");
            Console.ReadKey();
        }

        public static void BornBefore1962(IEnumerable<Family> familyMembers)
        {
            var query = from n in familyMembers
                where n.BirthDate.Year < 1962
                select n;


            foreach (var member in query)
                Console.WriteLine($"Name: {member.FirstsName} {member.LastName}, DOB: {member.BirthDate:D}");
            Console.ReadKey();
        }
    }
}