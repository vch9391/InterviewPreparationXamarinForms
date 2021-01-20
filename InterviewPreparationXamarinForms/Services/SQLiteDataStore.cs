using System;
using System.Threading.Tasks;
using InterviewPreparationXamarinForms.Models;

namespace InterviewPreparationXamarinForms.Services
{
    public class SQLiteDataStore : IDataStore<Item>
    {
        public Task<bool> AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
