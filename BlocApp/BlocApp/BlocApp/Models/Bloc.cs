using System;
using SQLite;

namespace BlocApp.Models
{
    public class Bloc
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime AcheivedDate { get; set; }
        public string Location { get; set; }
        public int NumberDone { get; set; }
        public int NumberFlashed { get; set; }

        #region Cotation
        public int IDCotation
        {
            get => _idCotation;
            set
            {
                _idCotation = value;
                var cotation = App.CotationDB.GetAsync(value).Result;
                Vermin = cotation.Vermin;
                Francais = cotation.Francais;
            }
        }
        private int _idCotation;

        public string Vermin { get; set; }
        public string Francais { get; set; }
        #endregion Cotation
    }
}
