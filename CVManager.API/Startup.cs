
using CVManager.Application.Mappings;
using CVManager.Application.Services;
using CVManager.Application.Validators;
using CVManager.Core.Repositories;
using CVManager.Core.Repositories.CVManager.Domain.Repositories;
using CVManager.Infrastructure.Data;
using CVManager.Infrastructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace CVManager.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add DbContext for EF Core and configure connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Register services for the repositories and application logic
            services.AddScoped<ICVRepository, CVRepository>();
            services.AddScoped<ICVService, CVService>();        // CV application service

            // Add AutoMapper for DTO mapping
            services.AddAutoMapper(typeof(CVProfile));  // Register AutoMapper mapping profile

            // Add FluentValidation
            services.AddControllers()
                 .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CVValidator>());

            // Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CV Manager API", Version = "v1" });
            });

            // Add CORS support
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });

            // Add MVC controllers
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CV Manager API v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            // Enable CORS
            app.UseCors("AllowAll");

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();  // Map controller routes
            });
        }
    }
}
