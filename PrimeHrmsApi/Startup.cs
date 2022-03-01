using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.Logging;
using PrimeHrmsApi.Domain.Entities;
using PrimeHrmsApi.Domain.Settings;
using PrimeHrmsApi.Infrastructure.Extension;
using PrimeHrmsApi.Service;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeHrmsApi
{
    public class Startup
    {
        private readonly IConfigurationRoot configRoot;
        private AppSettings AppSettings { get; set; }

        public Startup(IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
            Configuration = configuration;
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            configRoot = builder.Build();

            AppSettings = new AppSettings();
            Configuration.Bind(AppSettings);

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddController();
            services.AddDbContext(Configuration, configRoot);



            services.AddDbContext(Configuration, configRoot);

            services.AddIdentityService(Configuration);


            services.AddScopedServices();

            services.AddTransientServices();

            services.AddSwaggerOpenAPI();

            services.AddMailSetting(Configuration);

            services.AddServiceLayer();

            services.AddVersion();

            services.AddHealthCheck(AppSettings, Configuration);

            services.AddFeatureManagement();



            //services.AddMvc();
            //services.AddRazorPages();
            //services.AddDbContext<HRMS_ONLINEContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PrimeHrms")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory log)
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

            //app.UseCors(options =>
            //   options.WithOrigins("http://localhost:3000")
            //   .AllowAnyHeader()
            //   .AllowAnyMethod());

            app.ConfigureCustomExceptionMiddleware();

            log.AddSerilog();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.ConfigureSwagger();
            app.UseHealthChecks("/healthz", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
                ResultStatusCodes =
                {
                    [HealthStatus.Healthy] = StatusCodes.Status200OK,
                    [HealthStatus.Degraded] = StatusCodes.Status500InternalServerError,
                    [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable,
                },
            }).UseHealthChecksUI(setup =>
            {
                setup.ApiPath = "/healthcheck";
                setup.UIPath = "/healthcheck-ui";
                //setup.AddCustomStylesheet("Customization/custom.css");
            });
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
