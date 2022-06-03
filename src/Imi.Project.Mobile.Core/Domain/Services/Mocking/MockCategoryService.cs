using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockCategoryService : ICategoryService
    {
        private static List<Category> categoriesList = new List<Category>
        {
            new Category{ Name = "Hoofdgerecht" },
            new Category{ Name = "Voorgerecht" },
            new Category{ Name = "Bijgerecht" },
            new Category{ Name = "Hapjes" },
            new Category{ Name = "Snacks" },
            new Category{ Name = "Dessert" },
            new Category{ Name = "Brood" }
        };

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categories = categoriesList.ToList();
            return await Task.FromResult(categories);
        }

        Task<IEnumerable<CategoryResponseDto>> ICategoryService.GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}