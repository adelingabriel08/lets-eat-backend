using System;
using System.Collections.Generic;

namespace Lets_Eat_beckend.Models
{
    public class Order
    {
        public string Date { get; }
        public List<MenuItemOrder> MenuItemsOrder { get; set; }
        public Order()
        {
            Date = new DateTime().ToString();
            MenuItemsOrder = new List<MenuItemOrder>();
        }
    }
}