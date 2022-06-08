using TodoApi.Entities;

namespace TodoApi.Repositories
{
    public interface IItemsRepository
    {
        Item? GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void createItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }

}