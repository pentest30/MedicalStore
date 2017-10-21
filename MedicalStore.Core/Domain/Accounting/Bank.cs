using MedicalStore.Core.Domain.Common;

namespace MedicalStore.Core.Domain.Accounting
{
    public class Bank:BaseEntity
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address Address { get; set; }

    }
}
