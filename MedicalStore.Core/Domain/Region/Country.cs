using System.Collections.Generic;
using MedicalStore.Core.Domain.Catalog;
using MedicalStore.Core.Domain.Common;

namespace MedicalStore.Core.Domain.Region
{
    public partial class Country: BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the alias.
        /// </summary>
        /// <value>
        /// The alias.
        /// </value>
        public string Alias { get; set; }

        /// <summary>
        /// Gets or sets the manifacturers.
        /// </summary>
        /// <value>
        /// The manifacturers.
        /// </value>
        public ICollection<Manifacturer> Manifacturers { get; set; }
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        public ICollection<State> States { get; set; }
        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        public ICollection<Address> Addresses { get; set; }
    }
}
