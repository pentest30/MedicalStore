
namespace MedicalStore.Core.Domain.Orders
{
    /// <summary>
    /// Represents a return status
    /// </summary>
    public enum ReturnRequestStatus
    {
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 0,
        /// <summary>
        /// Received
        /// </summary>
        Received = 10,
        /// <summary>
        /// Return authorized
        /// </summary>
        ReturnAuthorized = 20,
       
        /// <summary>
        /// Request rejected
        /// </summary>
        RequestRejected = 50,
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancelled = 60,
    }
}
