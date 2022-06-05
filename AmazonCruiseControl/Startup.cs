using DriverMetrix.Adapter.Contracts;
using DriverMetrix.Adapter.Implementation;
using DriverMetrix.Data.Contracts;
using DriverMetrix.Data.Repositories;
using DriverMetrix.Facade.Contracts;
using DriverMetrix.Facade.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonCruiseControl
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
            services.AddTransient<IDriverMetrixAdapter, DriverMetrixAdapter>();
            services.AddTransient<IDriverMetrixRepository, DriverMetrixRepository>();
            services.AddTransient<IRouteRepository, RouteRepository>();
            services.AddTransient<IRouteFacade, RouteFacade>();
            services.AddTransient<IDriverMetrixFacade, DriverMetrixFacade>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
