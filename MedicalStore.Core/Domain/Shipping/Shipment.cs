using MedicalStore.Core.Domain.Orders;

namespace MedicalStore.Core.Domain.Shipping
{
    public class Shipment:BaseEntity
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
