using System.Web.Mvc;
using OAD.Service;

namespace OAD.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            var orderList = _orderService.GetAllOrders();

            return View(orderList);
        }
    }
}