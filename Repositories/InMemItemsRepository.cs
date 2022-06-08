using System.Linq;
using TodoApi.Entities;

namespace TodoApi.Repositories
{


    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item {Id=Guid.NewGuid(), Name= "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
            new Item {Id=Guid.NewGuid(), Name= "Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow},
            new Item {Id=Guid.NewGuid(), Name= "Shield", Price = 10, CreatedDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item? GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}