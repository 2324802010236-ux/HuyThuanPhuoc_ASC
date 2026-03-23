namespace ASC.Model.Common
{
    public interface IAuditTracker
    {
        string? CreatedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        string? ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}