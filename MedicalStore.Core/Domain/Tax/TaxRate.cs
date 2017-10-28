using System.Collections.Generic;
using MedicalStore.Core.Domain.Orders;

namespace MedicalStore.Core.Domain.Tax
{
    public partial class TaxRate:BaseEntity
    {
        public decimal Rate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
