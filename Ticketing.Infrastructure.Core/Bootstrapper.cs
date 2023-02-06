﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ticketing.Application;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaAgg.Services;
using Ticketing.Infrastructure.EFCore;
using Ticketing.Infrastructure.EFCore.Services;

namespace Ticketing.Infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Set(IServiceCollection services, string connectionString)
        {
            // Database Services

            #region  Database Services

            services.AddDbContext<TicketingContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IFormSchemaRepository, FormSchemaRepository>();

            #endregion

            #region Applications

            // FormSchema
            services.AddTransient<IFormSchemaValidator, FormSchemaValidator>();
            services.AddTransient<IFormSchemaApplication, FormSchemaApplication>();

            // FormSchemaField
            services.AddTransient<IFormSchemaFieldValidator, FormSchemaFieldValidator>();
            //services.AddTransient<IFormSchemaFieldApplication, FormSchemaFieldApplication>();

            #endregion
        }
    }
}