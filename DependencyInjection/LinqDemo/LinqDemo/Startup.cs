using LinqDemo.DemoLinq;
using LinqDemo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LinqDemo", Version = "v1" });
            });
            //Dependency Injection Methods:

            #region AddTransient
            //AddTansient means creates new instance for eaach request 

            ////services.AddTransient<ITestRepository, TestRepository>();
            ////services.AddTransient<TestServices, TestServices>();
            #endregion
            #region AddSingleTon
            //AddSingleTon means creates only one instance for whole application.
            //it creates single instance for each the request.

            //services.AddSingleton<ITestRepository, TestRepository>();
            //services.AddSingleton<TestServices, TestServices>();
            #endregion

            #region AddScoped
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<TestServices, TestServices>();
            #endregion



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LinqDemo v1"));
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
