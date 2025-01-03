﻿using green_city_be.DOMAIN.Core.DTO;
using green_city_be.DOMAIN.Core.Entities;
using green_city_be.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace green_city_be.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] UserAddDTO userAddDTO)
        {
            var validTypes = new[] { "CIU", "AUL", "ADM" };
            if (!validTypes.Contains(userAddDTO.Type))
            {
                return BadRequest("El campo 'type' solo puede tener los valores: CIU, AUL o ADM.");
            }

            var result = await _userService.SignUp(userAddDTO);
            if (!result) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] UserAuthDTO authDTO)
        {
            var result = await _userService.SignIn(authDTO.Email, authDTO.Password);
            if (result == null) return NotFound();
            return Ok(result);

        }
    }
}
