using System.Collections.Generic;
using MedicalStore.Core.Domain.Customers;

namespace MedicalStore.Core.Domain.Catalog
{
    public partial class ProductSetting: BaseEntity
    {
        /// <summary>
        /// The customeres
        /// </summary>
        private ICollection<Customer> _customers;

        /// <summary>
        /// Gets or sets the type of the access.
        /// </summary>
        /// <value>
        /// The type of the access.
        /// </value>
        public AccessType AccessType { get; set; }
        /// <summary>
        /// Gets or sets the produc identifier.
        /// </summary>
        /// <value>
        /// The produc identifier.
        /// </value>
        public int ProducId { get; set; }
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the customeres.
        /// </summary>
        /// <value>
        /// The customeres.
        /// </value>
        public ICollection<Customer> Customers {
            get { return _customers ?? (_customers = new List<Customer>()); }
            protected set { _customers = value; }
        }
    }

    public enum AccessType
    {
        Public,
        Customers,
        Private,
        Custom

    }
}
