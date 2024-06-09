using System.Collections.Generic;

namespace FoodDeliveryApi1.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        // Optional, if you want to store images of restaurants

        // Navigation property
       // public ICollection<Menu> Menus { get; set; }
    }
}
