namespace FoodDeliveryApi1.Models
{
    // Models/Order.cs
    public class Order
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }
        public string CustomerName { get; set; }
        public string DeliverAddress { get; set; }
    }


}
