using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNet.BasicsDemo.Infrastructure.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(customer => customer.Id);
    }
}