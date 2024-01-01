using AutoMapper;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/addresses")]
    public class AddressController : ControllerBase
    {
        private IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("by-userId/{userId}"), Authorize]
        // User can only find their own addresses
        public IActionResult GetAddressesByUserId(Guid userId)
        {
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userIdParse))
            {
                return BadRequest("Invalid user ID in token.");
            }

            if (userIdParse != userId)
            {
                return Unauthorized("Invalid UserId: you cannot get addresses for provided userId.");
            }
            try
            {
                var addresses = _addressService.GetAddressesByUserId(userId);

                if (addresses == null || !addresses.Any())
                {
                    return NotFound();
                }

                return Ok(addresses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost(), Authorize]
        public ActionResult<AddressReadDTO> CreateNewAddress([FromBody] AddressCreateDTO addressCreateDTO)
        {
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userIdParse))
            {
                return BadRequest("Invalid user ID in token.");
            }

            if (userIdParse != addressCreateDTO.UserId)
            {
                return Unauthorized("Invalid UserId: you cannot get addresses for provided userId.");
            }
            try
            {
                return CreatedAtAction(nameof(CreateNewAddress), _addressService.CreateNewAddress(addressCreateDTO));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}