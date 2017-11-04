using System;
using System.ComponentModel.DataAnnotations.Schema;
using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Core.Domain.Accounting
{
    public class Entreprise: BaseEntity
    {
        /// <summary>
        /// Gets or sets the rib.
        /// </summary>
        /// <value>
        /// The rib.
        /// </value>
        public string Rib { get; set; }

        /// <summary>
        /// Gets or sets the accounting number.
        /// </summary>
        /// <value>
        /// The accounting number.
        /// </value>
        public string AccountingNumber { get; set; }

        /// <summary>
        /// Gets or sets the NRC.
        /// </summary>
        /// <value>
        /// The NRC.
        /// </value>
        public string Nrc { get; set; }
        /// <summary>
        /// Gets or sets the nif.
        /// </summary>
        /// <value>
        /// The nif.
        /// </value>
        public string Nif { get; set; }
        /// <summary>
        /// Gets or sets the nis.
        /// </summary>
        /// <value>
        /// The nis.
        /// </value>
        public string Nis { get; set; }

        /// <summary>
        /// Gets or sets the banck account.
        /// </summary>
        /// <value>
        /// The banck account.
        /// </value>
        public string BanckAccount { get; set; }

        /// <summary>
        /// Gets or sets the logo URI.
        /// </summary>
        /// <value>
        /// The logo URI.
        /// </value>
        public string LogoUri { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
    }
}
