using Autofac;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PROJECTManager.API.Middlewares;
using PROJECTManager.Data;
using PROJECTManager.IOC;
using System;

namespace PROJECTManager.API
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
            services.AddControllers().AddNewtonsoftJson().AddFluentValidation();

            services.AddDbContext<ApplicationDataContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:PROJECTManagerDB"], migration => migration.MigrationsAssembly("PROJECTManager.API")));

            services.AddSwaggerGen(x => x.SwaggerDoc(Configuration["Version"], new OpenApiInfo
            {
                Version = Configuration["Version"],
                Title = "PROJECTManager API",
                Description = "A application for control projects.",
                Contact = new OpenApiContact
                {
                    Name = "Pedro Octávio",
                    Email = "pedrooctavio.dev@outlook.com",
                    Url = new Uri("https://github.com/pedro-octavio")
                },
                License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri("https://github.com/pedro-octavio/PROJECTManager/blob/main/LICENSE")
                }
            }));
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new ModuleIOC());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(x =>
            {
                x.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint($"/swagger/{Configuration["Version"]}/swagger.json", "PROJECTManager");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
