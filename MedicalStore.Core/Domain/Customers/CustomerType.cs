﻿using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Customers
{
    public class CustomerType:BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

       // public ICollection<Customer> Customers { get; set; }
    }
}
