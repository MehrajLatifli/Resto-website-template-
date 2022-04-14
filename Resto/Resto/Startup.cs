using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Resto.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Resto
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
            services.AddRazorPages();

            string connection = @"Data Source=DESKTOP-EE1ACSQ;User ID=sa; Password=admin1234;Initial Catalog=Menu_Db;Integrated Security=True";

            services.AddDbContext<MenuDbContext>(options => options.UseSqlServer(connection));

            string connection2 = @"Data Source=DESKTOP-EE1ACSQ;User ID=sa; Password=admin1234;Initial Catalog=Team_Db;Integrated Security=True";

            services.AddDbContext<TeamDbContext>(options => options.UseSqlServer(connection2));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //    Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img")),
            //    RequestPath = "/wwwroot/img"
            //});

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Menu}/{action=Index}/{id?}/{id2?}");
            });
        }
    }
}
