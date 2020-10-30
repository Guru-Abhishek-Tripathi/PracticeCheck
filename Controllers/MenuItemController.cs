using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenuItemListing.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private List<MenuItem> menuitem=new List<MenuItem>()
            {
                new MenuItem
                {
                    Id=01,
                    Name="Noodles",
                    freeDelivery= true,
                    Price=30,
                    dateOfLaunch=new DateTime(2018,03,30),
                    Active=true
                },
                 new MenuItem
                {
                    Id=02,
                    Name="Manchurian",
                    freeDelivery= true,
                    Price=50,
                    dateOfLaunch=new DateTime(2018,04,30),
                    Active=true
                },
                  new MenuItem
                {
                    Id=03,
                    Name="Pizza",
                    freeDelivery= true,
                    Price=300,
                    dateOfLaunch=new DateTime(2019,03,30),
                    Active=true
                }
            };
        public List<string> li = new List<string>();
        // GET: api/<MenuItemController>
        [HttpGet]
        public List<string> Get()
        {
            for(int i=0;i<menuitem.Count;i++)
            {
                li.Add(menuitem[i].Name);
            }
            return li;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var item = menuitem.FirstOrDefault((p) => p.Id == id);

            return item.Name;
        }

       /* // POST api/<MenuItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
