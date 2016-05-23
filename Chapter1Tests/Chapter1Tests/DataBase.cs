using System.Data.Linq.Mapping;

namespace Chapter1Tests
{
    public class DataBase
    {
        [Table(Name = "myDBase")]
        class Dbase
        {
            [Column] public string Id;
            [Column] public string Name;
            [Column] public string Title;
        }
    }
}
