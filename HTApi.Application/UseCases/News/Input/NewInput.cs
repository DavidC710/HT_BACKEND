
namespace HTApi.Application.UseCases.News.Input
{
    public class NewInput
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}
