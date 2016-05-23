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

            //For SurfacePro 3
            var db = new DataContext(@"D:\SQL_DataBaseFiles\myDbase.mdf");

            //For SurfaceBook
            //var db = new DataContext(@"F:\SQL_DataBaseFiles\myDbase.mdf");
            var query = from c in db.GetTable<Dbase>()
                where c.Name == "Mike"
                select c;

            foreach(var record in query)
                Console.WriteLine($"Record: Name:{record.Name}, Title:{record.Title}");
        }
    }
}
