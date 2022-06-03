using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class RecipeThemesService
    {
        private static List<RecipeThemeItem> themes = new List<RecipeThemeItem>
        {
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "16" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "17" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "18" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "19" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "20" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "21" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "22" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "23" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "24" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "25" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "26" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "27" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "28" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "29" },
            new RecipeThemeItem { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "30" }
        };

        public Task<RecipeThemeListItem[]> GetList()
        {
            return Task.FromResult(themes.Select(x => new RecipeThemeListItem()
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray()
            );
        }

        public Task<RecipeThemeItem> GetNew()
        {
            return Task.FromResult(new RecipeThemeItem());
        }

        public Task<RecipeThemeItem> Get(Guid id)
        {
            return Task.FromResult(themes.SingleOrDefault(x => x.Id.Equals(id)));
        }

        public Task Create(RecipeThemeItem item)
        {
            Guid id = new Guid();
            item.Id = id;
            themes.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(RecipeThemeItem item)
        {
            var theme = themes.SingleOrDefault(x => x.Id.Equals(item.Id));
            if (theme == null)
            {
                throw new ArgumentException("Theme not found");
            }
            theme.Name = item.Name;
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var theme = themes.SingleOrDefault(x => x.Id.Equals(id));
            if (theme == null)
            {
                throw new ArgumentException("Theme not found");
            }

            themes.Remove(theme);
            return Task.CompletedTask;
        }
    }
}