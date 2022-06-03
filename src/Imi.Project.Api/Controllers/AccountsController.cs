using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Dtos.Account;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
#pragma warning disable CS1591

    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto register)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _accountService.Register(register);
            if (result == null)
            {
                return BadRequest("Something went wrong please try again");
            }
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginUserRequestDto login)
        {
            try
            {
                var result = await _accountService.Login(login);

                if (result.Succeeded)
                {
                    var responseDto = new LoginUserResponseDto { JwtToken = result.JwtToken };
                    return Ok(responseDto);
                }
                else
                {
                    return Unauthorized(result.ErrorMessages);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Source, ex.Message);
                return BadRequest(ModelState);
            }
        }
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}