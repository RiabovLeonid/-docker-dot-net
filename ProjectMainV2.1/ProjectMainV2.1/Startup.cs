using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuisnessLogicLayer;
using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Services;
using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Interfaces.RepositoryInterfaces;
using DataAccessLayer.Repositories.SQLRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ProjectMainV2._1
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
            #region Repositories
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ILimitValueRepository, LimitValueRepository>();
            services.AddTransient<ISpendingRepository, SpendingRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<ISpendingTypeRepository, SpendingTypeRepository>();
            #endregion

            #region Services
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<ISpendingService, SpendingService>();
            services.AddTransient<ISpendingTypeService, SpendingTypeService>();
            services.AddTransient<ILimitValueService, LimitValueService>();
            #endregion
            services.AddDbContext<MyDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("DataAccessLayer"));
            });
            services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
