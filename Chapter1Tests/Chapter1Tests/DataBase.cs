using System.Data.Linq.Mapping;

namespace Chapter1Tests
{
    [Table(Name = "myDBase")]
    class Dbase
    {
        [Column] public int Id;
        [Column] public string Name;
        [Column] public string Title;
    }
}
