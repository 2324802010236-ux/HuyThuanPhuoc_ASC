using ASC.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HuyThuanPhuoc_ASC.Web.Controllers
{
    public class ServiceRequestsController : Controller
    {
        private readonly IServiceRequestService _serviceRequestService;

        public ServiceRequestsController(IServiceRequestService serviceRequestService)
        {
            _serviceRequestService = serviceRequestService;
        }

        public async Task<IActionResult> Index()
        {
            var serviceRequests = await _serviceRequestService.GetAllAsync();
            return View(serviceRequests);
        }
    }
}