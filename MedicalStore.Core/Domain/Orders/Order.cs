using System;
using System.Collections.Generic;
using MedicalStore.Core.Domain.Catalog;
using MedicalStore.Core.Domain.Common;
using MedicalStore.Core.Domain.Customers;
using MedicalStore.Core.Domain.Shipping;
using MedicalStore.Core.Domain.Stores;

namespace MedicalStore.Core.Domain.Orders
{
    public partial class Order
    {
        /// <summary>
        /// The shipments
        /// </summary>
        private ICollection<Shipment> _shipments;
        /// <summary>
        /// The order items
        /// </summary>
        private ICollection<OrderItem> _orderItems;

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        /// <value>
        /// The order number.
        /// </value>
        public string OrderNumber { get; set; }
        /// <summary>
        /// Gets or sets the order unique identifier.
        /// </summary>
        /// <value>
        /// The order unique identifier.
        /// </value>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Gets or sets the store identifier.
        /// </summary>
        /// <value>
        /// The store identifier.
        /// </value>
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the billing address identifier.
        /// </summary>
        /// <value>
        /// The billing address identifier.
        /// </value>
        public int BillingAddressId { get; set; }

        /// <summary>
        /// Gets or sets the shipping address identifier.
        /// </summary>
        /// <value>
        /// The shipping address identifier.
        /// </value>
        public int? ShippingAddressId { get; set; }

        /// <summary>
        /// Gets or sets the order status identifier.
        /// </summary>
        /// <value>
        /// The order status identifier.
        /// </value>
        public int OrderStatusId { get; set; }

        /// <summary>
        /// Gets or sets the shipping status identifier.
        /// </summary>
        /// <value>
        /// The shipping status identifier.
        /// </value>
        public int ShippingStatusId { get; set; }

        /// <summary>
        /// Gets or sets the payment status identifier.
        /// </summary>
        /// <value>
        /// The payment status identifier.
        /// </value>
        public int PaymentStatusId { get; set; }

        /// <summary>
        /// Gets or sets the order discount.
        /// </summary>
        /// <value>
        /// The order discount.
        /// </value>
        public decimal OrderDiscount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Order"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        /// <value>
        /// The created on.
        /// </value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        /// <value>
        /// The billing address.
        /// </value>
        public virtual Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        /// <value>
        /// The shipping address.
        /// </value>
        public virtual Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets the store.
        /// </summary>
        /// <value>
        /// The store.
        /// </value>
        public Store Store { get; set; }

        /// <summary>
        /// Gets or sets the paid date.
        /// </summary>
        /// <value>
        /// The paid date.
        /// </value>
        public DateTime? PaidDate { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
       
        /// <summary>
        /// Gets or sets the shipments.
        /// </summary>
        /// <value>
        /// The shipments.
        /// </value>
        public virtual ICollection<Shipment> Shipments
        {
            get => _shipments ?? (_shipments = new List<Shipment>());
            protected set => _shipments = value;
        }
        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        /// <value>
        /// The order items.
        /// </value>
        public virtual ICollection<OrderItem> OrderItems
        {
            get => _orderItems ?? (_orderItems = new List<OrderItem>());
            protected set => _orderItems = value;
        }
        /// <summary>
        /// Gets or sets the order total
        /// </summary>
        public decimal OrderTotal { get; set; }
    }
}
