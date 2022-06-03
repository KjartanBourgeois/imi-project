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
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        /// <summary>
        /// Gets all the ingredients
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ingredients = await _ingredientService.ListAllAsync();
            return Ok(ingredients);
        }

        /// <summary>
        /// Get 1 ingredients by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var ingredient = await _ingredientService.GetByIdAsync(id);
            if (ingredient == null)
            {
                return NotFound("Ingredient is not found");
            }
            return Ok(ingredient);
        }

        /// <summary>
        /// Creates an ingredient
        /// </summary>
        /// <param name="ingredientRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Post(IngredientRequestDto ingredientRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var ingredientResponseDto = await _ingredientService.AddAsync(ingredientRequestDto);
            return CreatedAtAction(nameof(Get), new { id = ingredientRequestDto.Id }, ingredientResponseDto);
        }

        /// <summary>
        /// Updates an ingredient
        /// </summary>
        /// <param name="ingredientRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Put(IngredientRequestDto ingredientRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var ingreidentResponseDto = await _ingredientService.UpdateAsync(ingredientRequestDto);
            return Ok(ingreidentResponseDto);
        }

        /// <summary>
        /// Deletes an ingredient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ingredient = await _ingredientService.GetByIdAsync(id);
            if (ingredient == null)
            {
                return NotFound($"Ingredient with ID {id} does not exist");
            }

            await _ingredientService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}