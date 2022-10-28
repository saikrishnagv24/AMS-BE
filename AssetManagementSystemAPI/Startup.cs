
using AssetManagementSystemAPI.Interfaces.AssetTypeInterface;
using AssetManagementSystemAPI.Interfaces.HarddiscInterface;
using AssetManagementSystemAPI.Interfaces.LoginInterface;
using AssetManagementSystemAPI.Interfaces.RegisterInterface;
using AssetManagementSystemAPI.Model;
using AssetManagementSystemAPI.Services.AssetTypeServices;
using AssetManagementSystemAPI.Services.HarddiscServices;
using AssetManagementSystemAPI.Services.LoginServices;
using AssetManagementSystemAPI.Services.RegisterServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssetManagementSystemAPI
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
            services.AddDbContext<AmsDBContext>(Op => Op.UseSqlServer(Configuration.GetConnectionString("AmsDatabase")));
            var s = services.AddDbContext<AmsDBContext>(Op => Op.UseSqlServer(Configuration.GetConnectionString("AmsDatabase")));

            services.AddControllers();

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                            .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            services.AddScoped<IRegisterInterface, RegisterService>();
            services.AddScoped<IloginInterface, LoginService>();
            services.AddScoped<IAssetTypeInterface, AssetTypeService>();
            services.AddScoped<IHarddiscInterface, HarddiscService>();
            



            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AssetManagementSystemAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AssetManagementSystemAPI v1"));
            }

            app.UseCors("AllowAll");

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
