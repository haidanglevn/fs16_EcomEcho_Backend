using System.Security.Claims;
using EcommerceAPI.Business.src.Abstraction;
using EcommerceAPI.Business.src.DTO;
using EcommerceAPI.Business.src.Service;
using EcommerceAPI.Core.src.Entity;
using EcommerceAPI.Core.src.Parameter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controller.src.Controller
{
    [ApiController]
    [Route("api/[controller]s")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private ITokenService _tokenService;
        public UserController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
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

            var token = _tokenService.CreateToken(user);
            var response = new { access_token = token };
            return Ok(response);
        }

        [HttpPost("is-available")]
        public bool CheckEmail([FromBody] CheckEmailDTO checkEmailDTO)
        {
            var isEmailExist = _userService.CheckEmail(checkEmailDTO.Email);
            return !isEmailExist;
        }

        [HttpGet(), Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<UserReadDTO>> GetAllUsers([FromQuery] GetAllParams options)
        {
            return Ok(_userService.GetAllUsers(options));
        }

        [HttpGet("{userId}"), Authorize(Roles = "Admin")]
        public ActionResult<UserReadDTO> GetOneUser(Guid userId)
        {
            return Ok(_userService.GetOneUser(userId));
        }

        [HttpGet("profile"), Authorize]
        public ActionResult<UserReadDTO> GetCurrentUserProfile()
        {
            // Extract userId from the token claims
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userId))
            {
                return BadRequest("Invalid user ID in token.");
            }

            // Fetch the user profile using the userId
            var userProfile = _userService.GetOneUser(userId);
            if (userProfile == null)
            {
                return NotFound("User not found.");
            }

            return Ok(userProfile);
        }

        // Admin can update info of any users
        [HttpPatch("{userId}"), Authorize(Roles = "Admin")]
        public IActionResult UpdateUserAsAdmin(Guid userId, [FromBody] UserUpdateDTO userUpdateDTO)
        {
            var result = _userService.UpdateUser(userId, userUpdateDTO);
            if (!result)
            {
                return NotFound($"User with ID {userId} not found.");
            }
            return Ok($"[ADMIN] User with ID {userId} is updated successfully");
        }

        // User can only update its own info
        [HttpPatch("profile")]
        public IActionResult UpdateCurrentUserInfo([FromBody] UserUpdateDTO userUpdateDTO)
        {
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            _ = Guid.TryParse(userIdClaim, out Guid userIdClaimParse);

            var result = _userService.UpdateUser(userIdClaimParse, userUpdateDTO);
            if (!result)
            {
                return NotFound($"User with ID {userIdClaimParse} not found.");
            }
            return Ok($"[USER] Your user info is updated successfully");
        }

        [HttpDelete("{userId}"), Authorize(Roles = "Admin")]
        public IActionResult DeleteUser(Guid userId)
        {
            var result = _userService.DeleteUser(userId);
            if (!result)
            {
                return NotFound($"User with ID {userId} not found.");
            }
            return Ok($"[ADMIN] User with ID {userId} is deleted successfully");
        }

        [HttpPost("change-password")]
        [Authorize] // Ensure only authenticated users can access this method
        public IActionResult ChangePassword([FromBody] UserChangePasswordDTO changePasswordDTO)
        {
            // Extract userId from the token claims
            var userIdClaim = HttpContext.User.FindFirst("userId")?.Value;
            if (userIdClaim == null)
            {
                return Unauthorized("User ID is not found in the token.");
            }

            if (!Guid.TryParse(userIdClaim, out Guid userId))
            {
                return BadRequest("Invalid user ID in token.");
            }

            try
            {
                // Call the ChangePassword method from the UserService
                var result = _userService.ChangePassword(userId, changePasswordDTO);
                if (result)
                {
                    return Ok("Password changed successfully.");
                }
                else
                {
                    return BadRequest("Unable to change the password.");
                }
            }
            catch (Exception ex)
            {
                // Return a more specific error message or log the exception as needed
                return BadRequest(ex.Message);
            }
        }

    }
}
