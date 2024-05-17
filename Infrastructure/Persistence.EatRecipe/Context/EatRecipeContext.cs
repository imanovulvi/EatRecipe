using Domen.EatRecipe.Entitys;
using Domen.EatRecipe.Entitys.EntitysBase;
using Domen.EatRecipe.Entitys.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EatRecipe.Context
{
    public class EatRecipeContext:DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MealRecipe> MealRecipes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }

        public EatRecipeContext(DbContextOptions options):base(options)
        {
            
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=EatRecipeDb_1;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMapping());
            modelBuilder.ApplyConfiguration<Comment>(new CommentMapping());

            modelBuilder.ApplyConfiguration<MealRecipe>(new MealRecipeMapping());
            modelBuilder.ApplyConfiguration<Menu>(new MenuMapping());
            modelBuilder.ApplyConfiguration<Page>(new PageMapping());
            modelBuilder.ApplyConfiguration<User>(new UserMapping());
        }
    }
}
