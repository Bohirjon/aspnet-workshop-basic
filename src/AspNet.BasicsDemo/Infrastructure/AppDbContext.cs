using AspNet.BasicDemo.Core.Abstractions;
using AspNet.BasicDemo.Core.Entities;

namespace AspNet.BasicsDemo.Infrastructure;

public sealed class AppDbContext : DbContext, IContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public IQueryable<T> Set<T>() where T : class
    {
        throw new NotImplementedException();
    }

    public void Add(object entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(object entity)
    {
        throw new NotImplementedException();
    }

    public void Update(object entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}