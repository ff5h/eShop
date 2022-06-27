using eShop.API.BLL.Implementations;
using eShop.API.BLL.Interfaces;
using eShop.API.DAL;
using Microsoft.EntityFrameworkCore;

namespace eShop.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCoreDb(_configuration);
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.ConfigureServices();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCoreDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<CatalogContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")
                )
            );
            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICatalogService, CatalogService>();
            return services;
        }
    }
}
