using Imi.Project.Blazor.Interfaces;
using Imi.Project.Core.Models.MemoryGame;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class MemoryGameService : IMemoryGameService
    {
        private static List<RecipeCard> hardPlayCards = new List<RecipeCard>()
        {
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), ImageUrl = "/images/milkshake.png", Name = "Milkshake", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), ImageUrl = "/images/nasigoreng.png", Name = "Nasi Goreng", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), ImageUrl = "/images/pompoen-tomatensoep.png", Name = "Pompoen Tomatensoep", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), ImageUrl = "/images/tzatziki.png", Name = "Tzatziki", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), ImageUrl = "/images/vegan-mayonaise.png", Name = "Vegn Mayonaise", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), ImageUrl = "/images/milkshake.png", Name = "Milkshake", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), ImageUrl = "/images/nasigoreng.png", Name = "Nasi Goreng", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), ImageUrl = "/images/pompoen-tomatensoep.png", Name = "Pompoen Tomatensoep", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), ImageUrl = "/images/tzatziki.png", Name = "Tzatziki", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), ImageUrl = "/images/vegan-mayonaise.png", Name = "Vegn Mayonaise", Number = 2}
        };

        private static List<RecipeCard> mediumPlayCards = new List<RecipeCard>()
        {
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), ImageUrl = "/images/milkshake.png", Name = "Milkshake", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), ImageUrl = "/images/nasigoreng.png", Name = "Nasi Goreng", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), ImageUrl = "/images/milkshake.png", Name = "Milkshake", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), ImageUrl = "/images/nasigoreng.png", Name = "Nasi Goreng", Number = 2},
        };

        private static List<RecipeCard> easyPlayCards = new List<RecipeCard>()
        {
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 1},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), ImageUrl = "/images/aardbeien-softijs.png", Name = "Aardbeien Softijs", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), ImageUrl = "/images/bruschetta.png", Name = "Bruschetta", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), ImageUrl = "/images/brusselse-wafels.png", Name = "Brusselse Wafels", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), ImageUrl = "/images/dumplings.png", Name = "Dumplings", Number = 2},
            new RecipeCard{ Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), ImageUrl = "/images/groenesmoothie-spinazie-aardbeien.png", Name = "Groene Smoothie", Number = 2},
        };

        public Task<List<RecipeCard>> GetRecipeCards(DifficultyLevel difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case DifficultyLevel.Easy:
                    return Task.FromResult(hardPlayCards);
                    break;

                case DifficultyLevel.Normal:
                    return Task.FromResult(mediumPlayCards);
                    break;

                default:
                    return Task.FromResult(hardPlayCards);
                    break;
            }
        }
    }
}