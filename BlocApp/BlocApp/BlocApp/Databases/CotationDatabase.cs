using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using BlocApp.Models;

namespace BlocApp
{
    public class CotationDatabase : IDatabase<Cotation>
    {
        private readonly SQLiteAsyncConnection _database;

        public CotationDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cotation>().Wait();

            var cotations = new List<Cotation>
            {
            new Cotation{ Francais = "4", Vermin = "V0"},
            new Cotation{ Francais = "5", Vermin = "V1"},
            new Cotation{ Francais = "5+", Vermin = "V2"},
            new Cotation{ Francais = "6A", Vermin = "V3"},
            new Cotation{ Francais = "6B", Vermin = "V4"},
            new Cotation{ Francais = "6C", Vermin = "V5"},
            };

            SaveAllAsync(cotations);

            cotations = new List<Cotation>
            {
            new Cotation{ID = 1, Francais = "4", Vermin = "V0"},
            new Cotation{ID = 2, Francais = "5", Vermin = "V1"},
            new Cotation{ID = 3, Francais = "5+", Vermin = "V2"},
            new Cotation{ID = 4, Francais = "6A", Vermin = "V3"},
            new Cotation{ID = 5, Francais = "6B", Vermin = "V4"},
            new Cotation{ID = 6, Francais = "6C", Vermin = "V5"},
            };

            SaveAllAsync(cotations);
        }

        public void SaveAllAsync(List<Cotation> items)
        {
            foreach (var item in items)
            {
                SaveAsync(item);
            }
        }

        public Task<int> SaveAsync(Cotation item)
        {
            if (item.ID != 0)
                return _database.UpdateAsync(item);

            return _database.InsertAsync(item);
        }

        public Task<int> DeleteAsync(Cotation item)
        {
            return _database.DeleteAsync(item);
        }

        public Task<List<Cotation>> GetAllAsync(bool forceRefresh = false)
        {
            return _database.Table<Cotation>().ToListAsync();
        }

        public Task<Cotation> GetAsync(int id)
        {
            return _database.Table<Cotation>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }
    }
}
