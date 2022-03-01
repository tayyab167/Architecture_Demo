using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using PrimeHrmsApi.Domain;
using PrimeHrmsApi.Domain.Settings;
using PrimeHrmsApi.Service.Contract;
using PrimeHrmsApi.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace PrimeHrmsApi.Infrastructure.Extension
{
    public static class ConfigureServiceContainer
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
             IConfiguration configuration, IConfigurationRoot configRoot)
        {
            serviceCollection.AddDbContext<ApplicationContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("PrimeHrms") ?? configRoot["ConnectionStrings:PrimeHrms"]
                , b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));


        }

        //public static void AddAutoMapper(this IServiceCollection serviceCollection)
        //{
        //    var mappingConfig = new MapperConfiguration(mc =>
        //    {
        //        mc.AddProfile(new CustomerProfile());
        //    });
        //    IMapper mapper = mappingConfig.CreateMapper();
        //    serviceCollection.AddSingleton(mapper);
        //}

        public static void AddScopedServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());


        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDateTimeService, DateTimeService>();
            serviceCollection.AddTransient<IAccountService, AccountService>();
        }



        public static void AddSwaggerOpenAPI(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(setupAction =>
            {


                setupAction.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Architecture API",
                    Version = "v1",
                    Description = "Architecture API Description",
                });

                //setupAction.SwaggerDoc(
                //    "OpenAPISpecification",
                //    new OpenApiInfo()
                //    {
                //        Title = "Onion Architecture WebAPI",
                //        Version = "1",
                //        Description = "Through this API you can access customer details",
                //        Contact = new OpenApiContact()
                //        {
                //            Email = "amit.naik8103@gmail.com",
                //            Name = "Amit Naik",
                //            Url = new Uri("https://amitpnk.github.io/")
                //        },
                //        License = new OpenApiLicense()
                //        {
                //            Name = "MIT License",
                //            Url = new Uri("https://opensource.org/licenses/MIT")
                //        }
                //    });

                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Description = $"Input your Bearer token in this format - Bearer token to access this API",
                });
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            },
                        }, new List<string>()
                    },
                });
            });

        }

        public static void AddMailSetting(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            serviceCollection.Configure<MailSettings>(configuration.GetSection("MailSettings"));
        }

        public static void AddController(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddNewtonsoftJson();
        }

        public static void AddVersion(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }

        public static void AddHealthCheck(this IServiceCollection serviceCollection, AppSettings appSettings, IConfiguration configuration)
        {
            serviceCollection.AddHealthChecks()
                .AddDbContextCheck<ApplicationContext>(name: "Application DB Context", failureStatus: HealthStatus.Degraded)
                .AddUrlGroup(new Uri(appSettings.ApplicationDetail.ContactWebsite), name: "Prime HRMS API ", failureStatus: HealthStatus.Degraded)
                .AddSqlServer(configuration.GetConnectionString("PrimeHrms"));
            
            serviceCollection.AddHealthChecksUI(setupSettings: setup =>
            {
                setup.AddHealthCheckEndpoint("Basic Health Check", $"/healthz");
            }).AddInMemoryStorage();
        }


    }
}
