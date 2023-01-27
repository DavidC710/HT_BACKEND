
namespace HTApi.Application.UseCases.Configuration.Interface
{
    public interface IPageConfiguration
    {
        Task<List<ConfigurationDTO>> GetAll();
        Task<PageConfiguration> Create(PageConfigurationInput input);
        Task<PageConfiguration> Update(UpdatePageConfigurationInput input);
    }
}
