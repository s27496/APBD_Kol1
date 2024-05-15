using System.Data.SqlClient;

namespace Kolokwium1;

public interface IOrderRepository
{
    public IEnumerable<Order> FetchOrdersById(int id);
    public bool DeleteClient(int clientId);
}

public class OrderRepository : IOrderRepository
{
    public IEnumerable<Order> FetchOrdersById(int id)
    {
        var connection = new SqlConnection(Program.ConnectionString);
        connection.Open();
        var command =
            new SqlCommand(
                $"SELECT * FROM \"Order\" JOIN dbo.Order_Product OP on [Order].IdOrder = OP.IdOrder JOIN dbo.Product P on OP.IdProduct = P.IdProduct WHERE [Order].IdOrder = {id} ORDER BY P.Name",
                connection);
        var reader = command.ExecuteReader();
        var orders = new List<Order>();
        while (reader.Read())
        {
            var order = new Order()
            {
                Id = (int)reader["IdOrder"],
                Name = reader["Name"].ToString()!,
                Description = reader["Description"].ToString()!,
                CreationDate = (DateTime)reader["CreationDate"],
                ClientId = (int)reader["ClientId"]
            };
            orders.Add(order);
        }

        return orders;
    }

    public bool DeleteClient(int id)
    {
        // throw new NotImplementedException();
        return true;
    }
}