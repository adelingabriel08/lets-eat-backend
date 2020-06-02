using System.Collections.Generic;
using Lets_Eat_beckend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lets_Eat_beckend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemsController : ControllerBase
    {
        public static List<MenuItem> MenuItems= new List<MenuItem>();

        public MenuItemsController()
        {
            MenuItems.Add(new MenuItem(){Name = "Pizza Capricioasa", 
                Image = "unlink", Allergens = "alergeni", Ingredients = "ingrediente", Price = 30});
            MenuItems.Add(new MenuItem(){Name = "Pizza Carbonara", 
                Image = "unlink", Allergens = "alergeni", Ingredients = "ingrediente", Price = 30});
            MenuItems.Add(new MenuItem(){Name = "Pizza Diavola", 
                Image = "unlink", Allergens = "alergeni", Ingredients = "ingrediente", Price = 30});
            MenuItems.Add(new MenuItem(){Name = "Pizza Napoleon", 
                Image = "unlink", Allergens = "alergeni", Ingredients = "ingrediente", Price = 30});
            MenuItems.Add(new MenuItem(){Name = "Pizza Prosciutto", 
                Image = "unlink", Allergens = "alergeni", Ingredients = "ingrediente", Price = 30});
            
        }

        [HttpGet]
        public List<MenuItem> GetMenuItems()
        {
            return MenuItems;
        }
    }
}