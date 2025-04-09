using MicroShop.Domain;

namespace MicroShop.Application;
public interface IOrderService { Order CreateOrder(string customerName); }
public class OrderService : IOrderService
{
    public Order CreateOrder(string customerName) => new Order { Id = 1, CustomerName = customerName };
}