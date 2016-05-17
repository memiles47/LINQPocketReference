namespace Chapter1Tests
{
    internal class Program
    {
        private static void Main()
        {
            var ch1Examples = new FirstExamples();
            ch1Examples.FirstExampleSet();
     
            var peopleSetOne = new GetPeople();
            var familyMembers = peopleSetOne.GetFamily();

            Family.BornBefore1962(familyMembers);

            Family.ShortFamilyNames(familyMembers);
        }
    }
}
