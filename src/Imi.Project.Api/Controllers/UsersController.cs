using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
#pragma warning disable CS1591

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "SuperAdmin")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get all the users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.ListAllAsync();
            return Ok(users);
        }

        /// <summary>
        /// Get 1 user by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound("User is not found");
            }
            return Ok(user);
        }

        /// <summary>
        /// Create an new user
        /// </summary>
        /// <param name="userRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dtoResponse = await _userService.AddAsync(userRequestDto);
            return CreatedAtAction(nameof(Get), new { id = userRequestDto.Id }, dtoResponse);
        }

        /// <summary>
        /// Update an user
        /// </summary>
        /// <param name="userRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtoResponse = await _userService.UpdateAsync(userRequestDto);
            return Ok(dtoResponse);
        }

        /// <summary>
        /// Delete an user by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound($"User with {id} is not found");
            }

            await _userService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}