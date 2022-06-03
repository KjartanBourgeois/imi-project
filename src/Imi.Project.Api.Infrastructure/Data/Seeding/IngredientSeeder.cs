using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class IngredientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Rode peper" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Soja Saus" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Aardappel" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Tomaat" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Ei" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Knoflook" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Pompoen" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Vodka" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Yoghurt" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Melk" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Boter" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Olijfolie" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Wortel" },
                new Ingredient { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Zout" }
                );
        }
    }
}
