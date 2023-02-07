using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ticketing.Application;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaAgg.Services;
using Ticketing.Domain.FormSchemaFieldAgg;
using Ticketing.Domain.FormSchemaFieldAgg.Services;
using Ticketing.Infrastructure.EFCore;
using Ticketing.Infrastructure.EFCore.Services;

namespace Ticketing.Infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Set(IServiceCollection services, string connectionString)
        {
            #region Database Services

            services.AddDbContext<TicketingContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IFormSchemaRepository, FormSchemaRepository>();
            services.AddTransient<IFormSchemaFieldRepository, FormSchemaFieldRepository>();

            #endregion

            #region Applications

            // FormSchema
            services.AddTransient<IFormSchemaValidator, FormSchemaValidator>();
            services.AddTransient<IFormSchemaApplication, FormSchemaApplication>();

            // FormSchemaField
            services.AddTransient<IFormSchemaFieldValidator, FormSchemaFieldValidator>();
            services.AddTransient<IFormSchemaFieldApplication, FormSchemaFieldApplication>();

            #endregion
        }
    }
}