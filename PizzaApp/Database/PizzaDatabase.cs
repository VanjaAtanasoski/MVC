using PizzaApp.Models.Entities;

namespace PizzaApp.Database
{
    public static class PizzaDatabase
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza(323232,1,"Margarita",true),
            new Pizza(3434,2,"Capri",true),
            new Pizza(42424,3,"Boki",false)
        };

        public static List<User> USERS = new List<User>()
        {
            new User(2,"vanja","Ata","razl","323232"),
            new User(3,"vanja1","Ata1","razl1","3232321"),
            new User(4,"vanja2","Ata2","razl2","3232322"),
        };

        public static List<Order> ORDERS = new List<Order>()
        {
            new Order(22,new User(3,"vanja1","Ata1","razl1","3232321"),new Pizza(3434,2,"Capri",true)),
            new Order(23,new User(2,"vanja","Ata","razl","323232"),new Pizza(3434,2,"Capri",true)),

        };
    }
}
