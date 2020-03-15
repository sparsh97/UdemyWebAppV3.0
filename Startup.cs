using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UdemyWeb.Models;

namespace UdemyWeb
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BlogPostsContext")));
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
    builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
            });
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller}/{action=Index}/{id?}");
            });
            app.UseSpa(spa =>
            {
            /*spa.Options.SourcePath = "blog";
            if (env.IsDevelopment())
            {
                spa.UseAngularCliServer(npmScript: "start");
                spa.Options.StartupTimeout = new TimeSpan(0, 5, 0);
            }*/
                spa.Options.StartupTimeout = new TimeSpan(0, 0, 360);
            //spa.UseAngularCliServer(npmScript: "start");
            spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            });
            /* app.UseMvc(routes =>
             {
                 routes.MapRoute(
                 name: "default",
                 template: "{controller}/{action=Index}/{id?}");
             });*/
        }
    }
}


