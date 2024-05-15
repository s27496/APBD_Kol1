using Microsoft.AspNetCore.Mvc;

namespace Kolokwium1;

[ApiController]
[Route("/api")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("/order/{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult FetchOrderById([FromRoute] int id)
    {
        var orders = _orderService.FetchOrdersById(id);
        return Ok(orders);
    }

    [HttpDelete("/client/{clientId:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteClient([FromRoute] int clientId)
    {
        var success = _orderService.DeleteClient(clientId);
        return success ? StatusCode(StatusCodes.Status200OK) : NotFound();
    }
}