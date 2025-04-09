using MicroShop.Application;
using MicroShop.Domain;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService) => _orderService = orderService;
    [HttpPost]
    public ActionResult<Order> CreateOrder([FromBody] string customerName)
    {
        var order = _orderService.CreateOrder(customerName);
        return Ok(order);
    }
}