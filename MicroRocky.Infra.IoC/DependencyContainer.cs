using MicroRocky.Product.Data.Context;
using MicroRocky.Product.Data.Repository;
using MicroRocky.Product.Domain.Interfaces;
using MicroRocky.Production.Application.Interfaces;
using MicroRocky.Production.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            // services.AddTransient<AppDBContext>

            //Application Services
            services.AddTransient<ICategoryService, CategoryService>();

            //Data
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<AppDBContext>();
        }
    }
}
