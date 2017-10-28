using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Accounting
{
    public partial class PayementMethod:BaseEntity

    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        public ICollection<Payement> Payements { get; set; }
    }
}
