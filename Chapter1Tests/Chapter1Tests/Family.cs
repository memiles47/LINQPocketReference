using System.Collections.Generic;

namespace Chapter1Tests
{
    internal static class Family
    {
        public static List<string> Names()
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
            return names;
        }
    }
}