namespace AspNet.BasicDemo.Core.Repositories;

public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(IContext context) : base(context)
    {
    }
}