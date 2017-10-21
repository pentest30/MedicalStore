using System;
using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Core.Domain.Accounting
{
    public class Payement:BaseEntity
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the on create.
        /// </summary>
        /// <value>
        /// The on create.
        /// </value>
        public DateTime OnCreate { get; set; }

        /// <summary>
        /// Gets or sets the payement status.
        /// </summary>
        /// <value>
        /// The payement status.
        /// </value>
        public PayementStatus PayementStatus { get; set; }
        /// <summary>
        /// Gets or sets the paid ammount.
        /// </summary>
        /// <value>
        /// The paid ammount.
        /// </value>
        public decimal AdvancedAmount { get; set; }

        /// <summary>
        /// Gets or sets to paid amount.
        /// </summary>
        /// <value>
        /// To paid amount.
        /// </value>
        public decimal ToPaidAmount { get; set; }

        /// <summary>
        /// Gets or sets the payement method identifier.
        /// </summary>
        /// <value>
        /// The payement method identifier.
        /// </value>
        public int PayementMethodId { get; set; }

        /// <summary>
        /// Gets or sets the payement method.
        /// </summary>
        /// <value>
        /// The payement method.
        /// </value>
        public PayementMethod PayementMethod { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }


    }
}
