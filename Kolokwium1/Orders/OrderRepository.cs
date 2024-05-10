namespace Kolokwium1;

public interface IOrderRepository
{
    public IEnumerable<Order> FetchOrdersById(int id);
    public bool DeleteClient(int id);
}

public class OrderRepository : IOrderRepository
{
    public IEnumerable<Order> FetchOrdersById(int id)
    {
        throw new NotImplementedException();
    }

    public bool DeleteClient(int id)
    {
        throw new NotImplementedException();
    }
}