using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Customers
{
    public class Role:BaseEntity
    {

        /// <summary>
        /// The customers
        /// </summary>
        private ICollection<Customer> _customers;

        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
      
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
       
        public virtual ICollection<Customer> Customers
        {
            get { return _customers ?? (_customers = new List<Customer>()); }
            protected set { _customers = value; }
        }
    }
}
