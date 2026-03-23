using ASC.Model.Domain;

namespace ASC.Business.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
    }
}