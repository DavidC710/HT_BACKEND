
namespace HTApi.Models
{
    public class PageConfiguration : BaseModel
    {
        public int Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}