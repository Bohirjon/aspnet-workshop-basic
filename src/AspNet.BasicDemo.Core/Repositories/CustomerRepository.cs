namespace AspNet.BasicDemo.Core.Repositories;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(IContext context) : base(context)
    {
    }
}