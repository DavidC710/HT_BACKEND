
namespace HTApi.Application.UseCases.News.Interface
{
    public interface INew
    {
        Task<List<NewDTO>> GetAll();
        Task<New> Create(NewInput input);
        Task<New> Update(UpdateNewInput input);
    }
}
