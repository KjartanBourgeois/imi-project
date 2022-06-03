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
    public class ThemesController : ControllerBase
    {
        private readonly IThemeService _themeService;

        public ThemesController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        /// <summary>
        /// Gets all the themes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var themes = await _themeService.ListAllAsync();
            return Ok(themes);
        }

        /// <summary>
        /// Get 1 theme by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var theme = await _themeService.GetByIdAsync(id);
            if (theme == null)
            {
                return NotFound("Theme is not found");
            }
            return Ok(theme);
        }

        /// <summary>
        /// Gets all the recipes of an specific theme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/recipes")]
        public async Task<IActionResult> GetAllRecipesByThemeId(Guid id)
        {
            var themeRecipe = await _themeService.GetRecipeByRecipeIdAsync(id);
            if (themeRecipe == null)
            {
                return NotFound("Kitchen is not found ");
            }

            return Ok(themeRecipe);
        }

        /// <summary>
        /// Create an new theme
        /// </summary>
        /// <param name="themeRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Post(ThemeRequestDto themeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dtoResponse = await _themeService.AddAsync(themeRequestDto);
            return CreatedAtAction(nameof(Get), new { id = themeRequestDto.Id }, dtoResponse);
        }

        /// <summary>
        /// Update an theme
        /// </summary>
        /// <param name="themeRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Put(ThemeRequestDto themeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtoResponse = await _themeService.UpdateAsync(themeRequestDto);
            return Ok(dtoResponse);
        }

        /// <summary>
        /// Delete an theme by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var theme = await _themeService.GetByIdAsync(id);
            if (theme == null)
            {
                return NotFound($"Theme with ID {id} does not exist");
            }

            await _themeService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}