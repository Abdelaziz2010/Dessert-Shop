namespace PieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
        public int? PieId { get; set; }
        public Pie Pie { get; set; }
    }
}
