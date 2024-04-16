using Hospital.Models;
using Hospital_api.Helper;
using Hospital_entities;
using Hospital_services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IBearerAuthentication _authenticationService;
        private readonly IUserRepository _userRepository;

        public AuthController(IBearerAuthentication authenticationService, IUserRepository userRepository)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserCreateMapper userCredentials)
        {
            try
            {
                var token = await _authenticationService.AuthenticateAsync(userCredentials.Username, userCredentials.Password);

                if (token == null)
                    return Unauthorized("Invalid username or password");

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /*[HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserCreateMapper newUser)
        {
            try
            {
                var existingUser = await _userRepository.GetUserByUsernameAsync(newUser.Username);
                if (existingUser != null)
                    return Conflict("Username is already taken");

                var user = new User
                {
                    UserName = newUser.Username,
                    Password = newUser.Password // You may want to hash the password before storing it
                    // Additional properties can be mapped here if necessary
                };

                await _userRepository.CreateUserAsync(user);

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }*/
    }

}

