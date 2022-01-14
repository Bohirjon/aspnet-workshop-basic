namespace AspNet.BasicsDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpGet]
    public Task<IEnumerable<CompanyViewModel>> Get() => _companyService.GetAllCompanies();

    [HttpGet("{id:guid}")]
    public Task<CompanyViewModel> GetById(Guid id) => _companyService.GetCompanyById(id);

    [HttpPost]
    public Task<CompanyViewModel> Post([FromBody] CreateCompanyCommand command) => _companyService.CreateCompany(command);

    [HttpPatch("{id:guid}")]
    public async Task<IActionResult> Patch(Guid id, [FromBody] UpdateCompanyInfoCommand command)
    {
        var found = await _companyService.UpdateCompanyInfo(command);
        return found ? Ok() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var found = await _companyService.DeleteCompany(id);
        return found ? Ok() : NotFound();
    }
}