using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ticketing.Application;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.FormReply;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Domain.FormAgg;
using Ticketing.Domain.FormAgg.Services;
using Ticketing.Domain.FormReplyAgg;
using Ticketing.Domain.FormReplyAgg.Services;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaAgg.Services;
using Ticketing.Domain.FormSchemaFieldAgg;
using Ticketing.Domain.FormSchemaFieldAgg.Services;
using Ticketing.Domain.FormSchemaTypeAgg;
using Ticketing.Domain.FormSchemaTypeAgg.Services;
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
            services.AddTransient<IFormSchemaTypeRepository, FormSchemaTypeRepository>();
            services.AddTransient<IFormSchemaRepository, FormSchemaRepository>();
            services.AddTransient<IFormSchemaFieldRepository, FormSchemaFieldRepository>();
            services.AddTransient<IFormRepository, FormRepository>();
            services.AddTransient<IFormReplyRepository, FormReplyRepository>();

            #endregion

            #region Applications

            // FormSchemaType
            services.AddTransient<IFormSchemaTypeValidator, FormSchemaTypeValidator>();
            services.AddTransient<IFormSchemaTypeApplication, FormSchemaTypeApplication>();

            // FormSchema
            services.AddTransient<IFormSchemaValidator, FormSchemaValidator>();
            services.AddTransient<IFormSchemaApplication, FormSchemaApplication>();

            // FormSchemaField
            services.AddTransient<IFormSchemaFieldValidator, FormSchemaFieldValidator>();
            services.AddTransient<IFormSchemaFieldApplication, FormSchemaFieldApplication>();

            // Form
            services.AddTransient<IFormValidator, FormValidator>();
            services.AddTransient<IFormApplication, FormApplication>();

            // FormReply
            services.AddTransient<IFormReplyValidator, FormReplyValidator>();
            services.AddTransient<IFormReplyApplication, FormReplyApplication>();

            #endregion
        }
    }
}