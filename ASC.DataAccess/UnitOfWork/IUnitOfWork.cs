using ASC.Model.Domain;
using ASC.DataAccess.Repository;

namespace ASC.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<ServiceRequest> ServiceRequests { get; }
        IRepository<MasterDataKey> MasterDataKeys { get; }
        IRepository<MasterDataValue> MasterDataValues { get; }
        IRepository<Product> Products { get; }

        Task<int> SaveChangesAsync();
    }
}