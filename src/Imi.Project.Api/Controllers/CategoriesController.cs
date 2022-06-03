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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Gets all the categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.ListAllAsync();
            return Ok(categories);
        }

        /// <summary>
        /// Gets 1 category by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound("Category is not found");
            }
            return Ok(category);
        }

        /// <summary>
        /// Gets all the recipes of one category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/recipes")]
        public async Task<IActionResult> GetAllRecipesByCategory(Guid id)
        {
            var categoryRecipe = await _categoryService.GetRecipesByCateogryIdAsync(id);
            if (categoryRecipe == null)
            {
                return NotFound("Category is not found ");
            }

            return Ok(categoryRecipe);
        }

        /// <summary>
        /// Updates an category
        /// </summary>
        /// <param name="categoryRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Put(CategoryRequestDto categoryRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryResponseDto = await _categoryService.UpdateAsync(categoryRequestDto);
            return Ok(categoryResponseDto);
        }

        /// <summary>
        /// Creates an category
        /// </summary>
        /// <param name="categoryRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Post(CategoryRequestDto categoryRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            categoryRequestDto.Id = Guid.NewGuid();
            var categoryResponseDto = await _categoryService.AddAsync(categoryRequestDto);
            return CreatedAtAction(nameof(Get), new { id = categoryRequestDto.Id }, categoryResponseDto);
        }

        /// <summary>
        /// Deletes an Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound($"Category with ID {id} does not exist");
            }

            await _categoryService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}