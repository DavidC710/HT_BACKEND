
namespace HTApi.Application.UseCases.News.DTOs
{
    public class NewDTO
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}
