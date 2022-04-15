using eTicketsHEALTHWEB.Data;
using eTicketsHEALTHWEB.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsHEALTHWEB
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
        {//configureSQLSERVERHERE*Startup.cs REMEMBER!
            //DbContext configuration //translator needs to know between wich data storages witch c# classes to translate
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString
                ("DefaultConnectionString")));

            //SERVICE CONFIGURATION AFTER DATA/SERVICES INTERFACE - CLASS - DoctorsController Rewrite

            services.AddScoped<IDoctorsService, DoctorsService>();
            services.AddScoped<ICompaniesService, CompaniesService>(); //steps: INTERFACE -(at base model EntityBase) +Class Service - Startup.cs 
            services.AddScoped<IHospitalsService, HospitalsService>(); //steps: INTERFACE -(at base model EntityBase) +Class Service - Startup.cs 
            services.AddScoped<IVirusNamesService, VirusNamesService>();

            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //Seed database*see Data/AppDdbInitializer.cs
            AppDbInitializer.Seed(app);
        }
    }
}
