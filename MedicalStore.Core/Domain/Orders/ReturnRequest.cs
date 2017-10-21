using System;
using MedicalStore.Core.Domain.Customers;
using MedicalStore.Core.Domain.Stores;

namespace MedicalStore.Core.Domain.Orders
{
    public partial class ReturnRequest:BaseEntity
    {

        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the order item identifier
        /// </summary>
        public Guid OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the reason to return
        /// </summary>
        public string ReasonForReturn { get; set; }

        /// <summary>
        /// Gets or sets the requested action
        /// </summary>
        public string RequestedAction { get; set; }

        /// <summary>
        /// Gets or sets the customer comments
        /// </summary>
        public string CustomerComments { get; set; }

        /// <summary>
        /// Gets or sets the staff notes
        /// </summary>
        public string StaffNotes { get; set; }

        /// <summary>
        /// Gets or sets the return status identifier
        /// </summary>
        public int ReturnRequestStatusId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of entity update
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }
        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the store.
        /// </summary>
        /// <value>
        /// The store.
        /// </value>
        public virtual Store Store { get; set; }

        /// <summary>
        /// Gets or sets the order item.
        /// </summary>
        /// <value>
        /// The order item.
        /// </value>
        public virtual OrderItem OrderItem { get; set; }

    }
}
