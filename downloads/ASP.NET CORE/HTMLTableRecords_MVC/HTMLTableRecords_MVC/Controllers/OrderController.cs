using HTMLTableRecords_MVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace HTMLTableRecords_MVC.Controllers
{

    public class OrderController : Controller
    {

        public ActionResult PlaceOrder()
        {
            List<OrderModel> objOrder = new List<OrderModel>()
            {
 new OrderModel {ProductCode="AOO1",ProductName="Windows Mobile",Qty=1,Price=45550.00,TotalAmount=45550.00 },
new OrderModel {ProductCode="A002",ProductName="Laptop",Qty=1,Price=67000.00,TotalAmount=67000.00 },
new OrderModel {ProductCode="A003",ProductName="LCD Television",Qty=2,Price=15000.00,TotalAmount=30000.00 },
new OrderModel {ProductCode="A004",ProductName="CD Player",Qty=4,Price=10000.00,TotalAmount=40000.00 }
            };
            
            OrderDetail ObjOrderDetails = new OrderDetail();
            ObjOrderDetails.OrderDetails = objOrder;
            return View(ObjOrderDetails);

        }

        [HttpPost]
        public ActionResult PlaceOrder(OrderDetail Order)
        {
            return View();
        }
    }
}

