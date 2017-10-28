using System;
using System.Collections.Generic;
using MedicalStore.Core.Domain.Catalog;
using MedicalStore.Core.Domain.Common;
using MedicalStore.Core.Domain.Customers;
using MedicalStore.Core.Domain.Orders;

namespace MedicalStore.Core.Domain.Stores
{
    public partial class Store :BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }

        public ICollection<Order> Orders { get; set; }
        public int AddressId { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
