using SMAService.Dao;
using SMAService.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMAService.Service
{
    public class ItemService : IService
    {
        private IDao dao=new InMemoryDao();

        public ItemService()
        {
            
        }

        public Item addItem(Item item)
        {
            return dao.addItem(item);
        }

        public List<Item> getItems(int index)
        {
            return dao.getItems(index);
        }

       
    }
}
