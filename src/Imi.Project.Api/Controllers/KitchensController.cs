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
    public class KitchensController : ControllerBase
    {
        private readonly IKitchenService _kitchenService;

        public KitchensController(IKitchenService kitchenService)
        {
            _kitchenService = kitchenService;
        }

        /// <summary>
        /// Gets all the kitchens
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var kitchens = await _kitchenService.ListAllAsync();
            return Ok(kitchens);
        }

        /// <summary>
        /// Get 1 kitchen by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var kitchen = await _kitchenService.GetByIdAsync(id);
            if (kitchen == null)
            {
                return NotFound($"Kitchen with {id} does not exist.");
            }
            return Ok(kitchen);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/recipes")]
        public async Task<IActionResult> GetAllRecipesByKitchenId(Guid id)
        {
            var kitchenRecipe = await _kitchenService.GetRecipeByKitchenIdAsync(id);
            if (kitchenRecipe == null)
            {
                return NotFound("Kitchen is not found ");
            }

            return Ok(kitchenRecipe);
        }

        /// <summary>
        /// Creates an kitchen
        /// </summary>
        /// <param name="kitchenRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Post(KitchenRequestDto kitchenRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dtoResponse = await _kitchenService.AddAsync(kitchenRequestDto);
            return CreatedAtAction(nameof(Get), new { id = kitchenRequestDto.Id }, dtoResponse);
        }

        /// <summary>
        /// Updates an kitchen
        /// </summary>
        /// <param name="kitchenRequestDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Policy = "OnlyAdmins")]
        public async Task<IActionResult> Put(KitchenRequestDto kitchenRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtoResponse = await _kitchenService.UpdateAsync(kitchenRequestDto);
            return Ok(dtoResponse);
        }

        /// <summary>
        /// Deletes an kitchen by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var kitchen = await _kitchenService.GetByIdAsync(id);
            if (kitchen == null)
            {
                return NotFound($"Kitchen with ID {id} does not exist");
            }

            await _kitchenService.DeleteAsync(id);
            return Ok();
        }
    }

#pragma warning restore CS1591
}