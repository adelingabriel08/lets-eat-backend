using System;
using System.Collections.Generic;
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
        public void CreateoOrderrAddItemsToOrder([FromBody] MenuItemOrder item)
        {
            if(CurrentOrder == null)
                CurrentOrder = new Order();
            CurrentOrder.MenuItemsOrder.Add(item);
        }
        [HttpGet]
        [Route("/orders/finish")]
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