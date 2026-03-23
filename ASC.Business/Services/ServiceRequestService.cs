using ASC.Business.Interfaces;
using ASC.DataAccess.UnitOfWork;
using ASC.Model.Domain;

namespace ASC.Business.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceRequestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ServiceRequest>> GetAllAsync()
        {
            var data = await _unitOfWork.ServiceRequests.GetAllAsync();
            return data.ToList();
        }
    }
}