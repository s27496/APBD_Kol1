﻿namespace Kolokwium1;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public int ClientId { get; set; }
}