using AutoMapper;
using Hospital.Models;
using Hospital_api.Helper;
using Hospital_entities;
using Hospital_services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateMapper userCreate)
        {
            try
            {
                if (!ModelState.IsValid)
                    return StatusCode(StatusCodes.Status400BadRequest, "fdvbsfdv");

                var user = _mapper.Map<User>(userCreate);
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                await _userRepository.CreateUserAsync(user);

                var createdUser = _mapper.Map<UserCreateMapper>(user);
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("CheckUser")]
        [AllowAnonymous]
        public async Task<IActionResult> CheckUser(UserCreateMapper userCredentials)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                User user = await _userRepository.GetUserByUsernameAsync(userCredentials.Username);

                if (user == null || !BCrypt.Net.BCrypt.Verify(userCredentials.Password, user.Password))
                    return BadRequest("Invalid username or password");

                return Ok(_mapper.Map<UserCreateMapper>(user));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }

}
