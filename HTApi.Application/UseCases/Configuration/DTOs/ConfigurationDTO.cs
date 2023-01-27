
namespace HTApi.Application.UseCases.Configuration.DTOs
{
    public class ConfigurationDTO
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
