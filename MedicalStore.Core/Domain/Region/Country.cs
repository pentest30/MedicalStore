using System.Collections.Generic;
using MedicalStore.Core.Domain.Catalog;
using MedicalStore.Core.Domain.Common;

namespace MedicalStore.Core.Domain.Region
{
    public partial class Country:BaseEntity
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

        public ICollection<Manifacturer> Manifacturers { get; set; }
        public ICollection<State> States { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
