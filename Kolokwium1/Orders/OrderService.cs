namespace Kolokwium1;

public interface IOrderService
{
    public IEnumerable<Order> FetchOrdersById(int id);
    public bool DeleteClient(int clientId);
}

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public IEnumerable<Order> FetchOrdersById(int id)
    {
        return _orderRepository.FetchOrdersById(id);
    }

    public bool DeleteClient(int clientId)
    {
        return _orderRepository.DeleteClient(clientId);
    }
}