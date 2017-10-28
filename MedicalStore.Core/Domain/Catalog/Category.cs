using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Catalog
{
    public partial class Category:BaseEntity
    {
        /// <summary>
        /// The products
        /// </summary>
        private ICollection<Product> _products;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
    
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
      
        public virtual ICollection<Product> Products
        {
            get { return _products ?? (_products = new List<Product>()); }
            protected set { _products = value; }
        }
    }
}
