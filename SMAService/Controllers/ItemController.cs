using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAService.Model;
using SMAService.Service;

namespace SMAService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IService service;


        public ItemController(IService src)
        {
            service= src;
        }

       [HttpGet]
        public IEnumerable<Item> Get()
        {
          
            return service.getItems(0);
        }


        [HttpGet("{start}", Name = "GetItem")]
        public IEnumerable<Item> Get(int start)
        {
            return service.getItems(start);

          
        }

     

        [HttpPost]
        public IActionResult Post([FromBody]Item item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            var addedItem = service.addItem(item);


            return CreatedAtRoute("GetItem", new { start = addedItem.Id }, addedItem);
        }

    }
}