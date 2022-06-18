namespace PizzaApp.Models.Entities
{
    public class User
    {   
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public User(int id,string firstName, string lastname, string address, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            Lastname = lastname;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
