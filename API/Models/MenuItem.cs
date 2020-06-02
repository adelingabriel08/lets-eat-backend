namespace Lets_Eat_beckend.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public string Allergens { get; set; }
        public uint Price { get; set; }
    }
}