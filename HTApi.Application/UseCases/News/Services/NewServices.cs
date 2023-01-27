
namespace HTApi.Application.UseCases.News.Services
{
    public class NewServices : BaseService, INew
    {
        private readonly DbSet<New> newRepository;
        public NewServices(HTDBContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
            newRepository = context.New;
        }

        public async Task<List<NewDTO>> GetAll() {
            var result = new List<NewDTO>();

            var dbNewsList = await newRepository.ToListAsync();

            foreach (var item in dbNewsList) { 
                var insert = new NewDTO();

                insert.Id = item.Id;
                insert.Order = item.Order;
                insert.Title = item.Title;
                insert.Text = item.Text;
                insert.Date = item.Date;

                result.Add(insert);
            }

            return result;
        }

        public async Task<New> Create(NewInput input)
        {
            var insert = new New();

            insert.Order = input.Order;
            insert.Title = input.Title;
            insert.Text = input.Text;
            insert.Date = input.Date;

            newRepository.Add(insert);
            await context.SaveChangesAsync();

            return insert;
        }

        public async Task<New> Update(UpdateNewInput input)
        {
            var record = await newRepository.Where(t => t.Id == input.Id).FirstOrDefaultAsync();
            record.Order = input.Order;
            record.Title = input.Title;
            record.Text = input.Text;
            record.Date = input.Date;

            newRepository.Update(record);
            await context.SaveChangesAsync();

            return record;
        }
    }
}
