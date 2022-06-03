using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RecipeIngredientsSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredients>().HasData(
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000001"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000001"), Amount = 1, },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000002"), Amount = 1, Unit = "centiliter" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000003"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000003"), Amount = 175 , Unit = "gram" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000004"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Amount = 4 },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000005"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000005"), Amount = 2 },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000006"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000006"), Amount = 1, Unit = "teentje" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000007"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000007"), Amount = 150, Unit = "gram" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000007"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Amount = 150, Unit = "teentje" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000007"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000004"), Amount = 1 },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000008"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000008"), Amount = 1, Unit = "centiliter" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000009"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000009"), Amount = 200, Unit = "yoghurt" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000010"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000010"), Amount = 25, Unit = "centiliter" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000011"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000011"), Amount = 80, Unit = "gram" },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000012"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000012"), Amount = 1.5, Unit = "centiliter"},
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000013"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000013"), Amount = 2 },
                new RecipeIngredients { RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000014"), IngredientId = Guid.Parse("00000000-0000-0000-0000-000000000014"), Amount = 1, Unit = "snuifje"}
                );
        }
    }
}
