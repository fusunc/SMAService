using SMAService.Model;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMAService.Dao
{
    public class InMemoryDao : IDao
    {
        private ConcurrentDictionary<int, Item> items = new ConcurrentDictionary<int, Item>();

        public Item addItem(Item item)
        {
            if (items.TryAdd(item.Id, item))
            {
                return item;
            }
            else
                return null;

        }

        public InMemoryDao()
        {
            //For test
            //items.TryAdd(1, new Item { Id = 1, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(2, new Item { Id = 2, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(3, new Item { Id = 3, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(4, new Item { Id = 4, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(5, new Item { Id = 5, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(6, new Item { Id = 6, Text = "xx", Name = "xx", Created = DateTime.Now });
            //items.TryAdd(7, new Item { Id = 7, Text = "xx", Name = "xx", Created = DateTime.Now });
        }
       
        public List<Item> getItems(int index)
        {
            List<Item> result = new List<Item>();
           
            foreach (var item in (items.Skip(index)).Take(5))
            {
                result.Add(item.Value);

            }
            return result;
        }

    }
}
