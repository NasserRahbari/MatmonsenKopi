using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ConceptsMicroservice.Models;
using NSwag.AspNetCore;
using NSwag.SwaggerGeneration.Processors;
using ConceptsMicroservice.Repositories;
using ConceptsMicroservice.Services;
using ConceptsMicroservice.Utilities;

namespace ConceptsMicroservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            AddDependencies(services);
            services.AddDbContext<ConceptsContext>(opt =>
                opt.UseInMemoryDatabase("ConceptsList"));
            services.AddSwagger();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            ConfigureSwagger(app);
            app.UseMvc();
        }

        /// <summary>
        /// Handles the initialization and configurations for OpenAPI (swagger).
        /// Is configured to support multiple API versions.
        /// </summary>
        /// <param name="app"></param>
        public void ConfigureSwagger(IApplicationBuilder app)
        {
            const string SWAGGER_BASE_URL = "/swagger";
            var v1_route = $"{SWAGGER_BASE_URL}/v1/swagger.json";

            app.UseSwaggerWithApiExplorer(config =>
            {
                config.GeneratorSettings.OperationProcessors.TryGet<ApiVersionProcessor>()
                    .IncludedVersions = new[] { "1.0" };
                config.SwaggerRoute = v1_route;

                config.GeneratorSettings.Title = "Concepts API";
                config.GeneratorSettings.Description = "API for NDLA's Concepts microservice";
            });

            app.UseSwaggerUi3(config =>
            {
                config.SwaggerRoutes.Add(new SwaggerUi3Route("v1.0", v1_route));
            });
        }
        public void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<IConceptService, ConceptService>();
            services.AddScoped<IConceptRepository, ConceptRepositoryFromFileDatabase>();
            services.AddScoped<IFileDB, FileDB>();
        }
    }
}
