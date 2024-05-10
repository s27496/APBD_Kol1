namespace Kolokwium1;

public class Order
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    DateTime CreationDate { get; set; }
    int IdClient { get; set; }
}