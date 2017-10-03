using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DifferenceBetweenScopedTransientSingleton.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DifferenceBetweenScopedTransientSingleton
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
            services.AddMvc();
            services.AddDbContext<ContextRepository>();
            services.AddSingleton<ICharacterRepository, CharacterRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(OptionRoute);
        }

        private void OptionRoute(IRouteBuilder obj)
        {
           obj.MapRoute("Default", "{Controller=Values}/{Action=Index}");
        }
    }
}
