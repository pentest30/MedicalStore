using System;

namespace MedicalStore.Core.Domain.Customers
{
    public class CustomerPlan:BaseEntity
    {
        /// <summary>
        /// Gets or sets the costuomer identifier.
        /// </summary>
        /// <value>
        /// The costuomer identifier.
        /// </value>
        public Guid CostuomerId { get; set; }
        /// <summary>
        /// Gets or sets the type of the plan.
        /// </summary>
        /// <value>
        /// The type of the plan.
        /// </value>
        public PlanType PlanType { get; set; }
        /// <summary>
        /// Gets or sets the started on.
        /// </summary>
        /// <value>
        /// The started on.
        /// </value>
        public DateTime StartedOn { get; set; }
        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>
        /// The end.
        /// </value>
        public DateTime End { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }

    }
}