using ASC.Business.Interfaces;
using ASC.DataAccess.UnitOfWork;
using ASC.Model.Domain;

namespace ASC.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var data = await _unitOfWork.Products.GetAllAsync();
            return data.ToList();
        }
    }
}