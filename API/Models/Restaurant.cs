namespace Lets_Eat_beckend.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Slug { get; set; }
        public MenuItem dailyMenu { get; set; }
    }
}