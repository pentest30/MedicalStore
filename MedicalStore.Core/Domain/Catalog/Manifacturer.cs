using System.Collections.Generic;
using MedicalStore.Core.Domain.Region;

namespace MedicalStore.Core.Domain.Catalog
{
    public class Manifacturer : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>

        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
       // public ICollection<Product> Products { get; set; }
    }
}
