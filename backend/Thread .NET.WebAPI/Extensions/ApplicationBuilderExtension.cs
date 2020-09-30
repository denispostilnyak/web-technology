using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Thread_.NET.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Thread_.NET.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app, IConfiguration configuration)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (bool.TryParse(configuration["Db:Migrations:Enable"], out var migrateDatabase) && migrateDatabase)
            {
                using (var serviceScope =
                    app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<ThreadContext>();
                    context.Database.Migrate();
                }

            }
            return app;
        }
    }
}
