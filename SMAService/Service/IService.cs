using SMAService.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMAService.Service
{
    public interface IService
    {
        public List<Item> getItems(int index);

        public Item addItem(Item item);
            
    }
}
