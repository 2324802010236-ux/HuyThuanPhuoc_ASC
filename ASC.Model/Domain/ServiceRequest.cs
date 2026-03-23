using ASC.Model.Common;

namespace ASC.Model.Domain
{
    public class ServiceRequest : BaseEntity, IAuditTracker
    {
        public string CustomerName { get; set; } = string.Empty;
        public string VehicleNumber { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}