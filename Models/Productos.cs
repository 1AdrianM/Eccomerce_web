namespace Ecommerce_project.Models
{
    public class Productos
    {
         
        public int ProductId { get; set; }
        public string?Title { get; set; }
        public string?Description { get; set; }
        public string?CategoryId{ get; set; }
        public int  stock_quantity { get; set; }
        public DateTime created_At { get; set; }
        public DateTime updated_At{ get; set; }


    }
}
