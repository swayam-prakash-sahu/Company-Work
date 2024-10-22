namespace HTMLTableRecords_MVC.Models
{
    public class OrderModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Int16 Qty { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
    }
    public class OrderDetail
    {
        public List<OrderModel> OrderDetails { get; set; }

    }
}
