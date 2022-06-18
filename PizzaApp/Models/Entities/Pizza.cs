namespace PizzaApp.Models.Entities
{
    public class Pizza
    {
        public Pizza(decimal price,int id, string name, bool isOnPromotion)
        {
            Price = price;
            Id = id;
            Name = name;
            IsOnPromotion = isOnPromotion;
        }

        public decimal Price { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsOnPromotion { get; set;}
    }
}
