using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PureFitnessV2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PureFitnessV2
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
            services.AddDbContext<CoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Database")));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /* 
            Can be used globally throughout the application: 
            1. env.IsDevelopment()      2. env.IsStaging()      3. env.IsProduction()
            */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // displays a developer friendly error page that shows: stack, query, cookies, and headers
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            // UseFileServer() = UseDefaultFiles + UseStaticFiles 
            // UseDefaultFiles(); can be called here as a Middleware service to defafult the load to default on runtime
            // allows use of static files such as html, css, and javascripts
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Sets the default route for the page on startup 
                // You can configure multiple routes 
                endpoints.MapControllerRoute(
                    // Route Name
                    name: "default",
                    // URL Pattern {controller}/{action}/{id}
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
