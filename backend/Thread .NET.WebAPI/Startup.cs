using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.DAL.Context;
using Thread_.NET.Extensions;
using Thread_.NET.Filters;

namespace Thread_.NET
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration).CreateLogger();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var server = Configuration["DBServer"] ?? "db";
            var port = Configuration["DBPort"] ?? "1401";
            var user = Configuration["DBUser"] ?? "SA";
            var password = "12345qwerASDF";
            var database = Configuration["Database"] ?? "ThreadContext";

            services.AddDbContext<ThreadContext>(options =>
                options.UseSqlServer($"Server={server};Database={database}; User ID={user}; Password={password};"));
            services.RegisterAutoMapper();

            services.RegisterCustomServices();
            services.RegisterCustomValidators();

            services.ConfigureJwt(Configuration);
            services.AddCors();

            services.AddSignalR();

            services
                .AddMvcCore(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                .AddAuthorization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddFluentValidation();

            services.ConfigureCustomValidationErrors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.MigrateDatabase(Configuration);
            app.UseStaticFiles();
            app.UseCors(builder => builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Token-Expired")
                .AllowCredentials()
                .WithOrigins("http://159.89.151.128:4200"));
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthentication();
			app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapControllers();
                cfg.MapHub<PostHub>("/notifications/post");
            });            
        }
    }
}
