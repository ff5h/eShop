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
            services.ConfigureIdentityDb(_configuration);

            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            services.ConfigureServices();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.ConfigureAuthentication(_configuration);
            services.ConfigureSwagger();
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

    static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureCoreDb(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContextPool<CoreDbContext>(options =>
            //    options.UseSqlServer(
            //        configuration.GetConnectionString("DefaultConnection")
            //    )
            //);
            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection ConfigureIdentityDb(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContextPool<IdentityDbContext>(options =>
            //    options.UseSqlServer(
            //        configuration.GetConnectionString("IdentityConnection")
            //    )
            //);
            //services.AddIdentityCore<User>(opts =>
            //{
            //    opts.Password.RequireDigit = false;
            //    opts.Password.RequireLowercase = false;
            //    opts.Password.RequireUppercase = false;
            //    opts.Password.RequireNonAlphanumeric = false;
            //    opts.User.RequireUniqueEmail = false;
            //    opts.User.AllowedUserNameCharacters = null;
            //})
            //    .AddRoles<IdentityRole>()
            //    .AddSignInManager()
            //    .AddDefaultTokenProviders()
            //    .AddEntityFrameworkStores<IdentityDbContext>();
            return services;
        }

        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            //var jwtConfig = configuration.GetSection(nameof(JwtConfiguration)).Get<JwtConfiguration>();
            //services.ConfigureJwtAuthService(jwtConfig);
            //services.AddSingleton<JwtSecurityTokenHandler>();
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Key));
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    options.SaveToken = true;
            //    options.RequireHttpsMetadata = false;
            //    options.TokenValidationParameters = new TokenValidationParameters()
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = key,
            //        ValidateIssuer = false,
            //        ValidateAudience = false,
            //        ClockSkew = TimeSpan.Zero
            //    };
            //});
            return services;
        }

        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            //services.AddSwaggerGen(swagger =>
            //{
            //    //This is to generate the Default UI of Swagger Documentation    
            //    swagger.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1",
            //        Title = "ASP.NET 6 Web API",
            //        Description = "Authentication and Authorization in ASP.NET 6 with JWT and Swagger"
            //    });
            //    // To Enable authorization using Swagger (JWT)    
            //    swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            //    {
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.ApiKey,
            //        Scheme = "Bearer",
            //        BearerFormat = "JWT",
            //        In = ParameterLocation.Header,
            //        Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
            //    });
            //    swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            //    {
            //        {
            //              new OpenApiSecurityScheme
            //              {
            //                    Reference = new OpenApiReference
            //                    {
            //                        Type = ReferenceType.SecurityScheme,
            //                        Id = "Bearer"
            //                    }
            //              },

            //              new string[] {}
            //        }
            //    });
            //});
            return services;
        }
    }
}
