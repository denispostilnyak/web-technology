using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using ProjectStructure.BL.UnitOfWork;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.DAL.Context;
using ProjectStructure.BL.Services;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.MapperProfiles;


namespace ProjectStructure.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            services.AddDbContext<ProjectStructureContext>(opt => opt
                .UseSqlServer(Configuration.GetConnectionString("LectureDatabase"), b=>b.MigrationsAssembly("ProjectStructure.DAL")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IQueriesService, QueriesService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(cfg =>
                {
                    cfg.AddProfile<ModelsProfile>();
                    cfg.AddProfile<LastProjectCountAndLongerTasksProfile>();
                },
                Assembly.GetExecutingAssembly());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
