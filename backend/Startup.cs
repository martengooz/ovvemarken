using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ovvemarken_backend.BL;
using ovvemarken_backend.Interfaces.DL;
using ovvemarken_backend.Interfaces.BL;
using ovvemarken_backend.DL;

namespace ovvemarken_backend
{
    public class Startup
    {
        readonly string DevelopmentOrigins = "_devOrigins";
        readonly string ProductionOrigins = "_prodOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: DevelopmentOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:3000")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            });

            services.AddControllers();

            // BL
            services.AddScoped<IPatchService, PatchService>();
            services.AddScoped<ISearchService, SearchService>();

            // DL
            services.AddScoped<IPatchRepository, PatchRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(DevelopmentOrigins);
            } 
            else
            {
                app.UseCors(ProductionOrigins);
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
