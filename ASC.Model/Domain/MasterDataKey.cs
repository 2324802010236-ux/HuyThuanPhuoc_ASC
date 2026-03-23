using ASC.Model.Common;

namespace ASC.Model.Domain
{
    public class MasterDataKey : BaseEntity, IAuditTracker
    {
        public string KeyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<MasterDataValue>? MasterDataValues { get; set; }
    }
}