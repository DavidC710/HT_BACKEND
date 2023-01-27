

    
namespace HTApi.Application.UseCases.Configuration.Services
{
    public class PageConfigurationServices : BaseService, IPageConfiguration
    {
        private readonly DbSet<PageConfiguration> pageConfigurationRepository;
        public PageConfigurationServices(HTDBContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
            pageConfigurationRepository = context.PageConfiguration;
        }

        public async Task<List<ConfigurationDTO>> GetAll() {
            var result = new List<ConfigurationDTO>();

            var dbConfigList = await pageConfigurationRepository.ToListAsync();

            foreach (var item in dbConfigList) { 
                var insert = new ConfigurationDTO();

                insert.Id = item.Id;
                insert.Type = item.Type;
                insert.Code = item.Code;
                insert.Description = item.Description;
                insert.Date = item.Date;

                result.Add(insert);
            }

            return result;
        }

        public async Task<PageConfiguration> Create(PageConfigurationInput input)
        {
            var insert = new PageConfiguration();

            insert.Code = input.Code;
            insert.Description = input.Description;
            insert.Date = input.Date;
            insert.Type = input.Type;

            pageConfigurationRepository.Add(insert);
            await context.SaveChangesAsync();

            return insert;
        }

        public async Task<PageConfiguration> Update(UpdatePageConfigurationInput input)
        {
            var record = await pageConfigurationRepository.Where(t => t.Id == input.Id).FirstOrDefaultAsync();
            record.Type = input.Type;
            record.Code = input.Code;
            record.Description = input.Description;
            record.Date = input.Date;

            pageConfigurationRepository.Update(record);
            await context.SaveChangesAsync();

            return record;
        }
    }
}
