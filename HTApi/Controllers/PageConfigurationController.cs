
namespace HTApi.Web.Controllers
{
   [ApiController]
    [Route("[controller]/[action]")]
    public class PageConfigurationController : ControllerBase
    {
        private readonly IPageConfiguration configuration;
        public PageConfigurationController(IPageConfiguration configuration) {
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<List<ConfigurationDTO>> GetAll()
        {
            return await configuration.GetAll();
        }

        [HttpPost]
        public async Task<PageConfiguration> Create(PageConfigurationInput input)
        {
            return await configuration.Create(input);
        }
    }
}
