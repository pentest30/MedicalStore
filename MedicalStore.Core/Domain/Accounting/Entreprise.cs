using System;
using System.ComponentModel.DataAnnotations.Schema;
using MedicalStore.Core.Domain.Customers;
using System.ComponentModel.DataAnnotations;

namespace MedicalStore.Core.Domain.Accounting
{
    public class Entreprise: BaseEntity
    {
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
        [Required]
        public Guid CustomerId { get; set; }
    }
}
