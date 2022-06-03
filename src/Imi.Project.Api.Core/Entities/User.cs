using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class User : IdentityUser
    {
        public bool TermsAndConditions { get; set; }
        public DateTime DoB { get; set; }
        public ICollection<Recipe> FavoriteRecipes { get; set; }
        public ICollection<RecipePhoto> RecipePhotos { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri ProfilePicture { get; set; }
        public Gender Gender { get; set; }
        public bool IsAdmin { get; set; }
    }
}