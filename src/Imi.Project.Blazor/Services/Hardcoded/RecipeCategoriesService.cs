using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class RecipeCategoriesService
    {
        private static List<RecipeCategoryItem> categories = new List<RecipeCategoryItem>
        {
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Hoofdgerecht" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Voorgerecht" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Bijgerecht" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Hapjes" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Snacks" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Dessert" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Brood" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Soepen" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Aperitief" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Smoothies" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Milkshakes" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Warme sausen" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Dips" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Babyvoeding" },
            new RecipeCategoryItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Vegan" }
        };

        public Task<RecipeCategoryListItem[]> GetList()
        {
            return Task.FromResult(categories.Select(x => new RecipeCategoryListItem()
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray()
            );
        }

        public Task<RecipeCategoryItem> GetNew()
        {
            return Task.FromResult(new RecipeCategoryItem());
        }

        public Task<RecipeCategoryItem> Get(Guid id)
        {
            return Task.FromResult(categories.SingleOrDefault(x => x.Id.Equals(id)));
        }

        public Task Create(RecipeCategoryItem item)
        {
            Guid id = new Guid();
            item.Id = id;
            categories.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(RecipeCategoryItem item)
        {
            var category = categories.SingleOrDefault(x => x.Id.Equals(item.Id));
            if (category == null)
            {
                throw new ArgumentException("Category not found");
            }
            category.Name = item.Name;
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var category = categories.SingleOrDefault(x => x.Id.Equals(id));
            if (category == null)
            {
                throw new ArgumentException("Category not found");
            }

            categories.Remove(category);
            return Task.CompletedTask;
        }
    }
}