using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Template_CifraDecifra_Testo.Models.Services.Application;

namespace Template_CifraDecifra_Testo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddTransient<ISecurityServices, SecurityService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseRouting();
            app.UseEndpoints(routeBuilder => {
                routeBuilder.MapControllerRoute("default", "{controller=Security}/{action=Index}/{id?}");
            });
        }
    }
}
