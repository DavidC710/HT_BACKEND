
namespace HTApi.Application
{
    public class BaseService
    {
        protected readonly HTDBContext context;
        protected readonly IHttpContextAccessor accessor;

        public BaseService(HTDBContext context, IHttpContextAccessor accessor)
        {
            this.context = context;
            this.accessor = accessor;
        }
    }
}
