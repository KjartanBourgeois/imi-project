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
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        /// <summary>
        /// Gets all the recipes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var recipes = await _recipeService.ListAllAsync();
            return Ok(recipes);
        }

        /// <summary>
        /// Get 1 recipe by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var recipe = await _recipeService.GetByIdAsync(id);
            if (recipe == null)
            {
                return NotFound("Recipe is not found");
            }
            return Ok(recipe);
        }

        /// <summary>
        /// Gets all ingredients of a recipe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/ingredients")]
        public async Task<IActionResult> GetIngredientsByRecipeId(Guid id)
        {
            var recipe = await _recipeService.GetIngredientsByRecipeIdAsync(id);
            if (recipe == null)
            {
                return NotFound("Recipe is not found");
            }
            return Ok(recipe);
        }

        /// <summary>
        /// Create an new recipe
        /// </summary>
        /// <param name="recipeRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Post(RecipeRequestDto recipeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dtoResponse = await _recipeService.AddAsync(recipeRequestDto);

            if (dtoResponse == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Get), new { id = recipeRequestDto.Id }, dtoResponse);
        }

        /// <summary>
        /// Updates an Recipe
        /// </summary>
        /// <param name="recipeRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Put(RecipeRequestDto recipeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtoResponse = await _recipeService.UpdateAsync(recipeRequestDto);
            return Ok(dtoResponse);
        }

        /// <summary>
        /// Deletes an recipe by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var recipe = await _recipeService.GetByIdAsync(id);
            if (recipe == null)
            {
                return NotFound($"Recipe with ID {id} does not exist");
            }

            await _recipeService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}