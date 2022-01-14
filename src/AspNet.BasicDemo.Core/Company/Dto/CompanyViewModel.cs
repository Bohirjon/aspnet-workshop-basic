namespace AspNet.BasicDemo.Core.Company.Dto;

public class CompanyViewModel : IMapFrom
{
    public string CompanyName { get; set; }
    public string CompanyWebSite { get; set; }

    public void Map(Profile profile)
    {
        profile.CreateMap<CompanyViewModel, Entities.Company>()
            .ForMember(company => company.Name, expression => expression.MapFrom(model => model.CompanyName))
            .ForMember(company => company.Website, expression => expression.MapFrom(model => model.CompanyWebSite))
            .ReverseMap();
    }
}