using System;
using System.Collections.Generic;

namespace Chapter1Tests
{
    public class GetPeople
    {
        public IList<Family> GetFamily()
        {
            var myFamily = new List<Family>
            {
                new Family() {FirstsName = "Dan", LastName = "Miles", BirthDate = new DateTime(1928, 1, 22)},
                new Family() {FirstsName = "Virginia", LastName = "Miles", BirthDate = new DateTime(1928, 4, 9)},
                new Family() {FirstsName = "Rick", LastName = "Miles", BirthDate = new DateTime(1947, 6, 7)},
                new Family() {FirstsName = "Chris", LastName = "Logue", BirthDate = new DateTime(1950, 9, 30)},
                new Family() {FirstsName = "Tyra", LastName = "Wingar", BirthDate = new DateTime(1952, 10, 21)},
                new Family() {FirstsName = "Mike", LastName = "Miles", BirthDate = new DateTime(1962, 8, 10)},
                new Family() {FirstsName = "Diane", LastName = "Waller", BirthDate = new DateTime(1964, 6, 12)},
            };

            return myFamily;
        }

        public IList<RandomPeople> RndPeople()
        {
            var people = new List<RandomPeople>
            {
                new RandomPeople() {FirstName = "Tom"},
                new RandomPeople() {FirstName = "Dick"},
                new RandomPeople() {FirstName = "Harry"},
                new RandomPeople() {FirstName = "Marry"},
                new RandomPeople() {FirstName = "Jay"}
            };

            return people;
        }

    }
}