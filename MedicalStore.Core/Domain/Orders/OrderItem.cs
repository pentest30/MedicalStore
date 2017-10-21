using System;
using MedicalStore.Core.Domain.Catalog;
using MedicalStore.Core.Domain.Tax;

namespace MedicalStore.Core.Domain.Orders
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the order item identifier.
        /// </summary>
        /// <value>
        /// The order item identifier.
        /// </value>
        public Guid OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
       
        public Order Order { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
       
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the tax rate identifier.
        /// </summary>
        /// <value>
        /// The tax rate identifier.
        /// </value>
        public int TaxRateId { get; set; }
        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>
        /// The tax rate.
        /// </value>
        public TaxRate TaxRate { get; set; }

    }
}
