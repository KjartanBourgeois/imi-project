using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class KitchenSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitchen>().HasData(
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Indisch" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Chinees" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Frans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Italiaans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Belgisch" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Grieks" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Spaans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Mexicaans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Japans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Libanees" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Thais" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Arabisch" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Thuiskeuken" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), Name = "Amerikaans" },
                new Kitchen { Id = Guid.Parse("00000000-0000-0000-0000-000000000015"), Name = "Andere" }
                );
        }
    }
}
