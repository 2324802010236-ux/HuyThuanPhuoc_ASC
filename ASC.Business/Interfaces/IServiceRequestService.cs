using ASC.Model.Domain;

namespace ASC.Business.Interfaces
{
    public interface IServiceRequestService
    {
        Task<List<ServiceRequest>> GetAllAsync();
    }
}