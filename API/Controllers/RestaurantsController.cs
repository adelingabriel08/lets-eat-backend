using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Lets_Eat_beckend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lets_Eat_beckend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class RestaurantsController : ControllerBase
    {
        public static List<Restaurant> restaurants = new List<Restaurant>();

        public RestaurantsController()
        {
            restaurants.Add(new Restaurant
            {
                Name = "Pizzeria Napoleon", Logo = "/assets/img/logo-napoleon.png", Slug = "napoleon",
                dailyMenu = new MenuItem
                    {Name = "Pizza", Image = "http://localhost:3000/assets/img/meniu-zilei.jpg", Ingredients = "ceva", Allergens = "ceva", Price = 10}
            });
            restaurants.Add(new Restaurant
            {
                Name = "Restaurant Merlot", Logo = "/assets/img/logo-merlot.jpeg", Slug = "merlot", dailyMenu = new MenuItem
                    {Name = "Pizza", Image = "/assets/img/meniu-zilei.jpg", Ingredients = "ceva", Allergens = "ceva", Price = 10}
            });
            restaurants.Add(new Restaurant
            {
                Name = "Cantina UPT", Logo = "/assets/img/logo-napoleon.png", Slug = "cantina", dailyMenu = new MenuItem
                    {Name = "Pizza", Image = "/assets/img/meniu-zilei.jpg", Ingredients = "ceva", Allergens = "ceva", Price = 10}
            });
        }

        [HttpGet]
        public List<Restaurant> GetAll()
        {
            return restaurants;
        }

        [HttpGet("{slug}")]
        public Restaurant GetBySlug([FromQuery] string slug)
        {
            var restaurant = restaurants.Find(resturant => resturant.Slug == slug);
            return restaurant;
        }

        [HttpPost]
        public void Add([FromBody] Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            Console.WriteLine(JsonSerializer.Serialize(restaurants));
        }
    }
}