using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Hoofdgerecht" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Voorgerecht" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Bijgerecht" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Hapjes" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Snacks" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Dessert" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Brood" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Soepen" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Aperitief" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Smoothies" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Milkshakes" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Warme sausen" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Dips" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Babyvoeding" },
                new Category { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Vegan" }
                );
        }
    }
}
