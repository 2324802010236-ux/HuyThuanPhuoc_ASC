using ASC.Model.Common;

namespace ASC.Model.Domain
{
    public class MasterDataValue : BaseEntity, IAuditTracker
    {
        public long MasterDataKeyId { get; set; }
        public string ValueName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public MasterDataKey? MasterDataKey { get; set; }
    }
}