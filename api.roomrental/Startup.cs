using api.roomrental.Data;
using api.roomrental.Entities;
using api.roomrental.models;
using api.roomrental.Models;
using api.roomrental.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using NLog.Extensions.Logging;

namespace api.roomrental
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<RoomrentalDbContext>(o =>
            o.UseSqlServer(Configuration.GetConnectionString("RoomRentalDatabase")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 0;
                options.User.RequireUniqueEmail= true;
            })
            .AddEntityFrameworkStores<RoomrentalDbContext>()
            .AddDefaultTokenProviders();


            // DB initialise only development
            services.AddScoped<DbInitializer, DbInitializer>();

            // Application serivices 
            services.AddTransient<IAuthService, AuthService>();
            services.AddAutoMapper(cfg => cfg.AddProfile(new MapperProfile()));
            services.AddCors();
            services.AddMvc().AddJsonOptions(options=> {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, DbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                dbInitializer.Seed().Wait();
            }

            loggerFactory.AddNLog();
            app.UseCors(options => options.AllowAnyOrigin());
            app.UseMvc();
        }
    }
}
