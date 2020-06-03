using System;
using System.Collections.Generic;
using System.Text.Json;
using Lets_Eat_beckend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lets_Eat_beckend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class OrderController
    {
        public static List<Order> Orders = new List<Order>();
        public static Order CurrentOrder;
        [HttpPost]
        public void CreateoOrderrAddItemsToOrder(MenuItemOrder item)
        {
            if(CurrentOrder == null)
                CurrentOrder = new Order();
            Console.WriteLine(JsonSerializer.Serialize(item));
            CurrentOrder.MenuItemsOrder.Add(item);
        }
        [HttpGet]
        [Route("/order/finish")]
        public Order FinishOrderAndGet()
        {
            var order = CurrentOrder;
            if (CurrentOrder != null)
            {
                Orders.Add(CurrentOrder);
                CurrentOrder = null;
            }
            return order;
        }

        [HttpGet]
        public List<Order> GetOrders()
        {
            return Orders;
        }

        [Route("/order/status")]
        [HttpGet]
        public Order GetCurrentOrder()
        {
            return CurrentOrder;
        }
        
    }
}