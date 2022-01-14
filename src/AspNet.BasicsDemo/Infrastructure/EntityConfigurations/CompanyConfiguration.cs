using AspNet.BasicDemo.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNet.BasicsDemo.Infrastructure.EntityConfigurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(company => company.Id);

        builder.HasMany(company => company.Customers)
            .WithOne(customer => customer.Company)
            .HasForeignKey(customer => customer.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}