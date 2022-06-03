using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class RecipeKitchensService
    {
        private static List<RecipeKitchenItem> kitchens = new List<RecipeKitchenItem>
        {
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "1" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "2" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "3" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "4" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "5" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "6" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "7" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "8" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "9" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "10" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "11" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "12" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "13" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "14" },
            new RecipeKitchenItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "15" }
        };

        public Task<RecipeKitchenListItem[]> GetList()
        {
            return Task.FromResult(kitchens.Select(x => new RecipeKitchenListItem()
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray()
            );
        }

        public Task<RecipeKitchenItem> GetNew()
        {
            return Task.FromResult(new RecipeKitchenItem());
        }

        public Task<RecipeKitchenItem> Get(Guid id)
        {
            return Task.FromResult(kitchens.SingleOrDefault(x => x.Id.Equals(id)));
        }

        public Task Create(RecipeKitchenItem item)
        {
            Guid id = new Guid();
            item.Id = id;
            kitchens.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(RecipeKitchenItem item)
        {
            var kitchen = kitchens.SingleOrDefault(x => x.Id.Equals(item.Id));
            if (kitchen == null)
            {
                throw new ArgumentException("Kitchen not found");
            }
            kitchen.Name = item.Name;
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var kitchen = kitchens.SingleOrDefault(x => x.Id.Equals(id));
            if (kitchen == null)
            {
                throw new ArgumentException("Kitchen not found");
            }

            kitchens.Remove(kitchen);
            return Task.CompletedTask;
        }
    }
}