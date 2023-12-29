using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/[controller]s")]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost(), Authorize]
        public ActionResult<OrderReadDTO> CreateNewOrder([FromBody] OrderCreateDTO orderCreateDTO)
        {
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userId))
            {
                return BadRequest("Invalid user ID in token.");
            }

            if (userId != orderCreateDTO.UserId)
            {
                return Unauthorized("Invalid UserId: you cannot create order with the provided userId.");
            }
            try
            {
                return CreatedAtAction(nameof(CreateNewOrder), _orderService.CreateNewOrder(orderCreateDTO));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(), Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<OrderReadDTO>> GetAllOrders([FromQuery] GetAllParams options)
        {
            return Ok(_orderService.GetAllOrders(options));
        }
    }
}