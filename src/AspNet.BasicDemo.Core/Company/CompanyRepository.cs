namespace AspNet.BasicDemo.Core.Company;

public class CompanyRepository : BaseRepository<Entities.Company>, ICompanyRepository
{
    public CompanyRepository(IContext context) : base(context)
    {
    }
}