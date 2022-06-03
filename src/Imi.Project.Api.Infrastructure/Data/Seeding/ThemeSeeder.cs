using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ThemeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theme>().HasData(
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Pasen" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Kerst" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Barbecue" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Gezond" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Halloween" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Herfst" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Zomer" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Winter" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Lente" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Raclette" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Aziatisch" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Alledaags" },
                    new Theme { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Babyvoeding" }
                );
        }
    }
}
