namespace AspNet.BasicDemo.Core.Customer;

public class CustomerRepository : BaseRepository<Entities.Customer>, ICustomerRepository
{
    public CustomerRepository(IContext context) : base(context)
    {
    }
}