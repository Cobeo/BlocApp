using SQLite;

namespace BlocApp.Models
{
    public class Cotation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Vermin { get; set; }
        public string Francais { get; set; }
    }

}
