using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<RecipePhoto> RecipePhotos { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<RecipeIngredients>()
                .ToTable("RecipeIngredients")
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            modelBuilder.Entity<RecipeIngredients>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<RecipeIngredients>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId);


            CategorySeeder.Seed(modelBuilder);
            KitchenSeeder.Seed(modelBuilder);
            ThemeSeeder.Seed(modelBuilder);
            IngredientSeeder.Seed(modelBuilder);
            RecipeSeeder.Seed(modelBuilder);
            RecipeIngredientsSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
            RecipePhotoSeeder.Seed(modelBuilder);

        }
    }
}
