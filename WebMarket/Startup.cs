using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebMarket.Controllers;
using WebMarket.Data;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Mocks;
using WebMarket.Data.Models;
using WebMarket.Data.Repository;

namespace WebMarket
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfigurationRoot _confString;

        public Startup(IHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<ICPU, CPURepository>();
            services.AddTransient<IProductRange, ProductRangeRepository>();
            services.AddTransient<IGPU, GPURepository>();
            services.AddTransient<IMotherboard, MBRepository>();
            services.AddTransient<IProductItem, MockProductItem>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => Basket.GetCart(sp));

            services.AddMvc(option => option.EnableEndpointRouting = false); //option => option.EnableEndpointRouting = false
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "cpu", template: "CPU/{action}/{Id?}", defaults: new { Controller = "CPU", action = "List" });
                routes.MapRoute(name: "gpu", template: "GPU/{action}/{Id?}", defaults: new { Controller = "GPU", action = "List" });
                routes.MapRoute(name: "mb", template: "MB/{action}/{Id?}", defaults: new { Controller = "MB", action = "List" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
            
        }
    }
}
