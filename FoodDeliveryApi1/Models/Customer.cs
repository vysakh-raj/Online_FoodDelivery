namespace FoodDeliveryApi1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; } // Optional, if you want to store customer addresses
        public string Phone { get; set; } // Optional, if you want to store customer phone numbers
    }
}
