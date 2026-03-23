using ASC.DataAccess.Context;
using ASC.DataAccess.Repository;
using ASC.Model.Domain;

namespace ASC.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IRepository<ServiceRequest> ServiceRequests { get; }
        public IRepository<MasterDataKey> MasterDataKeys { get; }
        public IRepository<MasterDataValue> MasterDataValues { get; }
        public IRepository<Product> Products { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ServiceRequests = new Repository<ServiceRequest>(_context);
            MasterDataKeys = new Repository<MasterDataKey>(_context);
            MasterDataValues = new Repository<MasterDataValue>(_context);
            Products = new Repository<Product>(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}