using TodoApi.Entities;

namespace TodoApi.Repositories
{
    public interface IItemsRepository
    {
        Item? GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}