using Microsoft.EntityFrameworkCore;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaFieldAgg;

namespace Ticketing.Infrastructure.EFCore;

public class TicketingContext : DbContext
{
    public TicketingContext(DbContextOptions<TicketingContext> options) : base(options) { }

    public DbSet<FormSchema> FormSchemas { get; set; }
    public DbSet<FormSchemaField> FormSchemasFields { get; set; }
}