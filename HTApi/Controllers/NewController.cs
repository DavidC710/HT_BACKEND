
using HTApi.Application.UseCases.News.DTOs;
using HTApi.Application.UseCases.News.Interface;

namespace HTApi.Web.Controllers
{
   [ApiController]
    [Route("[controller]/[action]")]
    public class NewController : ControllerBase
    {
        private readonly INew configuration;
        public NewController(INew configuration) {
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<List<NewDTO>> GetAll()
        {
            return await configuration.GetAll();
        }

        [HttpPost]
        public async Task<New> Create(NewInput input)
        {
            return await configuration.Create(input);
        }

        [HttpPut]
        public async Task<New> Update(UpdateNewInput input)
        {
            return await configuration.Update(input);
        }
    }
}
