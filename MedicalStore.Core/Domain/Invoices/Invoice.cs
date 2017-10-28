using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Core.Domain.Invoices
{
    public partial class Invoice:BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
