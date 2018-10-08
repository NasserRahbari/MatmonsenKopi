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
using System;
using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConceptsMicroservice
{
    public class Startup
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfiguration _config;

        private string GetDatabaseConncetion()
        {
            return _env.IsDevelopment()
                ? _config.GetConnectionString("ConceptsDatabase")
                : Environment.GetEnvironmentVariable("CONNECTION_STRING");
        }

        public Startup(IHostingEnvironment env, IConfiguration config)
        {
            _env = env;
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            AddDependencies(services);
            services.AddAutoMapper();
            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<ConceptsContext>(opt => opt.UseNpgsql(GetDatabaseConncetion()));
            services.AddSwagger();
            services.AddCors(
                options =>
                {
                    options.AddPolicy("AllowAll",
                        builder =>
                        {
                            builder
                                .AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowCredentials();
                        });
                }
                );
            services
                .AddMvc()
                    .AddJsonOptions(options => {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

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

            app.UseCors("AllowAll");

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
            services.AddScoped<IConceptRepository, ConceptRepository>();
            services.AddScoped<IMetadataService, MetadataService>();
            services.AddScoped<IMetadataRepository, MetadataRepository>();
            services.AddScoped<IFileDB, FileDB>();
        }
    }
}
