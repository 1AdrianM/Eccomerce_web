namespace Ecommerce_project.Models
{
    public class Detalles_Pedido
    {
        public int order_id  {get; set;}
public int  user_id { get; set; }
        public DateTime order_date { get; set; }
        public bool status { get; set; }
        public int total_price { get; set; }
        public string? shipping_address  {get; set;}
}
}
