using System;
using System.Linq;
using System.Data.Linq;

namespace Chapter1Tests
{
    internal class Program
    {
        private static void Main()
        {
            var peopleSet = new GetPeople();
            var familyMembers = peopleSet.GetFamily();
            var people = peopleSet.RndPeople();
            //var database = new DataBase();

            Console.WriteLine("Query tests on Names");
            Console.WriteLine("--------------------");

            FirstExamples.ShortNames(people);
            FirstExamples.FilteredNames(people);
            FirstExamples.OrderedList(people);


            Family.BornBefore1962(familyMembers);
            Family.ShortFamilyNames(familyMembers);
            Family.FamilyOrderedList(familyMembers);

            //From Essential LINQ (MICROSOFT WINDOWS DEVELOPER SERIES) CH2
            var family = from name in peopleSet.GetFamily()
                where name.BirthDate.Year >= 1962
                select new {fName = name.FirstsName, Lname = name.LastName, dob = name.BirthDate};

            foreach (var fnameAndLnameAnddob in family)
                Console.WriteLine(fnameAndLnameAnddob);
            Console.WriteLine();

            //Also from Essential LINQ
            var db = new DataContext(@"f:\SQL_DataBaseFiles\myDbase.mdf");
            var query = from item in db.GetTable<DataBase>()
                select item;

            Console.WriteLine($"The data is: {query}");
        }
    }
}
