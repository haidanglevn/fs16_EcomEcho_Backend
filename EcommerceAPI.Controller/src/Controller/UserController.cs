using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Core.src.Parameter;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]s")]
public class UserController : ControllerBase
{
    private IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet()]
    public ActionResult<IEnumerable<UserReadDTO>> GetAllUsers([FromQuery] GetAllParams options)
    {
        return Ok(_userService.GetAllUsers(options));
    }

    [HttpPost()]
    public ActionResult<UserReadDTO> CreateNewUser([FromBody] UserCreateDTO userCreateDTO)
    {
        return CreatedAtAction(nameof(CreateNewUser), _userService.CreateNewUser(userCreateDTO));
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLoginDTO userLoginDTO)
    {
        var user = _userService.Login(userLoginDTO.Email, userLoginDTO.Password);
        if (user == null)
        {
            return Unauthorized("Invalid credentials");
        }

        // You would normally generate a JWT token here, but for testing, you can just return a success message.
        return Ok("Login successful");
    }
}
