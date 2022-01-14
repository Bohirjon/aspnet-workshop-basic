namespace AspNet.BasicDemo.Core.Abstractions.Services;

public interface ICompanyService
{
    Task<IEnumerable<CompanyViewModel>> GetAllCompanies();
    Task<CompanyViewModel> GetCompanyById(Guid id);
    Task<CompanyViewModel> CreateCompany(CreateCompanyCommand createCompanyCommand);
    Task<bool> UpdateCompanyInfo(UpdateCompanyInfoCommand updateCompanyInfoCommand);
    Task<bool> DeleteCompany(Guid companyId);
}