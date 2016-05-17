using System.Collections.Generic;

namespace Chapter1Tests
{
    internal static class RandomPeople
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
            };
            return names;
        }
    }
}