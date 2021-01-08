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
using Newtonsoft.Json.Serialization;

namespace server
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
            services.Configure<StripeOptions>(options =>
            {
                options.PublishableKey = "pk_test_51I16cfC7KyW3yD03UZpJ0LKAzZ9ekix2QplsZuo2awdlxkvDnGWEKmSBOZQCc9TNgceITSnP6SSiLU09Ls5IaKrR00AO2Ramng";
                options.SecretKey = "sk_test_51I16cfC7KyW3yD03XMRfpkUwH5HYE1NJzkQdje67i8w9ytZSZ8hXRj0MyDJaQdFv6vpXfI5o5iv3LusaOysH3QoN00bo9xVBQn";
                options.WebhookSecret = "whsec_0GH2nMVDgSoODURhhmPvqrNtly8EpBUa";
                options.BasicPrice = "price_1I6oWLC7KyW3yD03gs5nt1DX";
                options.ProPrice = "price_1I6oWvC7KyW3yD03xXb7nCDJ";
                options.Domain = "http://localhost:4242";
            });

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy(),
                };
            });
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
            //app.UseHttpsRedirection();
            app.UseFileServer();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
