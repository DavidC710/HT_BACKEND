
namespace HTApi.Models
{
    public class New : BaseModel
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}