using ASC.Model.Common;

namespace ASC.Model.Domain
{
    public class Product : BaseEntity, IAuditTracker
    {
        public string ProductName { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}