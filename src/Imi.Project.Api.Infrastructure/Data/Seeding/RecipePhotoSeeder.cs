using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RecipePhotoSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipePhoto>().HasData(
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/nasigoreng.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/dumplings.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/aardappelpuree.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000004"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/bruschetta.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000005"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/brusselse-wafels.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000006"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/naanbrood-janos.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000007"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/pompoen-tomatensoep.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000008"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/longisland-icetea.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/groenesmoothie-spinazie-aardbeien.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000010"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/blog-kokenmetkinderen-milkshake.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000011"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/bechamelsaus.png", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000012"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/recepten/tzatziki.php", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000013"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/babyvoeding_appelwortel.jpg", HighlightedImage = true },
                    new RecipePhoto { Id = Guid.Parse("00000000-0000-0000-0000-000000000014"), RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000014"), UserId = Guid.Parse("00000000-0000-0000-0000-000000000011"), ImageLink = "https://www.alleskunner.be/images/vegan-mayonaise.png", HighlightedImage = true }
                );
        }
    }
}
