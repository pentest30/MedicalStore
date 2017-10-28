using System.Collections.Generic;
using MedicalStore.Core.Domain.Common;

namespace MedicalStore.Core.Domain.Region
{
    public partial class State:BaseEntity
    {
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        public int CountryId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public Country Country { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
