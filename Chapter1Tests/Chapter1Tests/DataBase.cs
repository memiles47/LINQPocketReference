using System.Data.Linq.Mapping;

namespace Chapter1Tests
{
    public class DataBase
    {
        [Table(Name = "myDBase")]
        private class Dbase
        {
            [Column] public int Id;
            [Column] public string Name;
            [Column] public string Title;
        }
    }
}
