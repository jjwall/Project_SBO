using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Project_SBO
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}