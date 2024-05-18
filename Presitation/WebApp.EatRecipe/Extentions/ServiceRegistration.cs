using Microsoft.EntityFrameworkCore;
using Persistence.EatRecipe.Context;
using Microsoft.Extensions.Configuration;
using Appilacation.EatRecipe.Repostarys;
using Persistence.EatRecipe.Repostarys;

namespace WebApp.EatRecipe.Extentions
{
    public static class ServiceRegistration
    {
        public static void AddAppService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EatRecipeContext>(x => x.UseSqlServer(configuration.GetConnectionString("EatCon")));
            services.AddScoped(typeof(IMenuReadRepostary),typeof(MenuReadRepostary));
            services.AddScoped(typeof(IMenuWriteRepostary), typeof(MenuWriteRepostary));
            services.AddScoped(typeof(IPageReadRepostary), typeof(PageReadRepostary));
            services.AddScoped(typeof(IPageWriteRepostary), typeof(PageWriteRepostary));
        }
    }
}
