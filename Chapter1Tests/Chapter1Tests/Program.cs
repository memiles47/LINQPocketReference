using System;
namespace Chapter1Tests
{
    internal class Program
    {
        private static void Main()
        {
            var peopleSet = new GetPeople();
            var familyMembers = peopleSet.GetFamily();
            var people = peopleSet.RndPeople();

            Console.WriteLine("Query tests on Names");
            Console.WriteLine("--------------------");

            FirstExamples.ShortNames(people);
            FirstExamples.FilteredNames(people);
            FirstExamples.OrderedList(people);


            Family.BornBefore1962(familyMembers);
            Family.ShortFamilyNames(familyMembers);
            Family.FamilyOrderedList(familyMembers);
        }
    }
}
