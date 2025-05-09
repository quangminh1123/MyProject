using API.Data;
using API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            // Th�m d?ch v? InMemoryCache
            services.AddDistributedMemoryCache(); // Cung c?p d?ch v? IDistributedCache
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDataProtection();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAccount, AccountResponse>();
            services.AddScoped<IProduct, ProductResponse>();
            services.AddScoped<IProductDetail, ProductDetailResponse>();
            services.AddScoped<IImage, ImageResponse>();
            services.AddScoped<ICategory, CategoryResponse>();
            services.AddScoped<ISize, SizeResponse>();
            services.AddScoped<IColor, ColorResponse>();
            services.AddScoped<ISupplier, SupplierResponse>();
            services.AddScoped<IEvaluate, EvaluateResponse>();
            services.AddScoped<ICategory, CategoryResponse>();
            services.AddScoped<IBill, BillResponse>();
            services.AddScoped<IBillDetail, BillDetailResponse>();
            services.AddScoped<ISale, SaleResponse>();
            services.AddScoped<ICart, CartResponse>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseRouting();

            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}