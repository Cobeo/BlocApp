using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using BlocApp.Models;

namespace BlocApp
{
    public class BlocDatabase : IDatabase<Bloc>
    {
        private readonly SQLiteAsyncConnection _database;

        public BlocDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Bloc>().Wait();
        }

        public void SaveAllAsync(List<Bloc> items)
        {
            foreach (var item in items)
                SaveAsync(item);
        }

        public Task<int> SaveAsync(Bloc item)
        {
            if (item.ID != 0)
                return _database.UpdateAsync(item);

            return _database.InsertAsync(item);
        }

        public Task<int> DeleteAllAsync()
        {
            return _database.DeleteAllAsync<Bloc>();
        }

        public Task<int> DeleteAsync(Bloc item)
        {
            return _database.DeleteAsync(item);
        }

        public Task<List<Bloc>> GetAllAsync(bool forceRefresh = false)
        {
            return _database.Table<Bloc>().ToListAsync();
        }

        public Task<Bloc> GetAsync(int id)
        {
            return _database.Table<Bloc>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }
    }
}
