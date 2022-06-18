namespace PizzaApp.Models.Entities
{
    public class Order
    {
        public Order(int id, User user, Pizza pizza)
        {
            Id = id;
            User = user;
            Pizza = pizza;
        }

        public int Id { get; set; }
        
        public User User { get; set; }

        public Pizza Pizza { get; set; }
      

        


    }
}
