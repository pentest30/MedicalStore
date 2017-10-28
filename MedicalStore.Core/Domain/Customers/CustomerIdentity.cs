using System;

namespace MedicalStore.Core.Domain.Customers
{
    public class CustomerIdentity:BaseEntity
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string IdentityPath { get; set; }
        /// <summary>
        /// Gets or sets the on create.
        /// </summary>
        /// <value>
        /// The on create.
        /// </value>
        public DateTime OnCreate { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the businnes register.
        /// </summary>
        /// <value>
        /// The businnes register.
        /// </value>
        public string BusinnesRegister { get; set; }
    }
}
