using TodoApi.Entities;

namespace TodoApi.Repositories
{
    public interface IItemsRepository
    {
        Task<Item>? GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();

        Task createItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }

}