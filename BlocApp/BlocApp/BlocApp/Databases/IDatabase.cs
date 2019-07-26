using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlocApp
{
    public interface IDatabase<T>
    {
        void SaveAllAsync(List<T> items);
        Task<int> SaveAsync(T item);
        Task<int> DeleteAsync(T item);
        Task<List<T>> GetAllAsync(bool forceRefresh = false);
        Task<T> GetAsync(int id);
    }
}
