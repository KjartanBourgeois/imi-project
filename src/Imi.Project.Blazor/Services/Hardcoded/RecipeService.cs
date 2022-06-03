using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class RecipeService
    {
        private static InputSelectItem[] categories = new InputSelectItem[]
        {
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000001") , Label = "Hoofdgerecht"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000002") , Label = "Voorgerecht"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000003") , Label = "Bijgerecht"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000004") , Label = "Hapjes"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000005") , Label = "Snacks"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000006") , Label = "Dessert"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000007") , Label = "Brood"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000008") , Label = "Soepen"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000009") , Label = "Aperitief"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000010") , Label = "Smoothies"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000011") , Label = "Milkshakes"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000012") , Label = "Warme sausen"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000013") , Label = "Dips"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000014") , Label = "Babyvoeding"},
            new InputSelectItem(){Value = Guid.Parse("00000000-0000-0000-0000-000000000015") , Label = "Vegan"}
        };

        private static List<RecipeItem> recipes = new List<RecipeItem>
        {
            new RecipeItem(){ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Title = "Nasi Goreng", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Title = "Dumplings",  CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000002")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Title = "Aardappelpuree", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Title = "Bruschetta", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000004")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Title = "Brusselse wafels",  CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000006")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Title = "Naambroodjes", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000007")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Title = "Pompoen tomatensoep", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000008")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Title = "Long Island iced tea", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000009")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Title = "Groene Smoothie", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000010")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Title = "Milkshake met frambozen", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000011")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Title = "Bechamelsaus", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000012")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Title = "Tzatziki", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000013")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Title = "Babyvoeding groenten/fruitpap", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000014")},
            new RecipeItem(){Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Title = "Vegan Mayonaise", CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000015")}
        };

        public Task<RecipeListItem[]> GetList()
        {
            return Task.FromResult(
                    recipes.Select(x => new RecipeListItem()
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Category = categories
                           .Where(c => c.Value == x.CategoryId)
                           .Select(c => c.Label)
                           .SingleOrDefault()
                    }).ToArray()
                    );
        }

        public Task<RecipeItem> GetNew()
        {
            var recipe = new RecipeItem();
            recipe.Categories = categories;
            recipe.CategoryId = categories.First().Value;
            return Task.FromResult(recipe);
        }

        public Task<RecipeItem> Get(Guid id)
        {
            var recipe = recipes.SingleOrDefault(x => x.Id.Equals(id));
            recipe.Categories = categories;
            return Task.FromResult(recipe);
        }

        public Task Create(RecipeItem item)
        {
            item.Id = Guid.NewGuid();
            recipes.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(RecipeItem item)
        {
            var recipe = recipes.SingleOrDefault(x => x.Id.Equals(item.Id));
            if (recipe == null)
            {
                throw new ArgumentException("Recipe not found.");
            }
            recipe.Title = item.Title;
            recipe.CategoryId = item.CategoryId;
            return Task.FromResult(recipe);
        }

        public Task Delete(Guid id)
        {
            var recipe = recipes.SingleOrDefault(x => x.Id.Equals(id));
            if (recipe == null)
            {
                throw new ArgumentException("Recipe not found");
            }
            recipes.Remove(recipe);
            return Task.CompletedTask;
        }
    }
}