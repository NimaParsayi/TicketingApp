using Microsoft.EntityFrameworkCore;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaFieldAgg;
using Ticketing.Domain.FormSchemaTypeAgg;
using Ticketing.Infrastructure.EFCore.Mappings;

namespace Ticketing.Infrastructure.EFCore;

public class TicketingContext : DbContext
{
    public TicketingContext(DbContextOptions<TicketingContext> options) : base(options) { }

    public DbSet<FormSchemaType> FormSchemaTypes { get; set; }
    public DbSet<FormSchema> FormSchemas { get; set; }
    public DbSet<FormSchemaField> FormSchemasFields { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FormSchemaTypeMapping());
        modelBuilder.ApplyConfiguration(new FormSchemaMapping());
        modelBuilder.ApplyConfiguration(new FormSchemaFieldMapping());

        base.OnModelCreating(modelBuilder);
    }
}