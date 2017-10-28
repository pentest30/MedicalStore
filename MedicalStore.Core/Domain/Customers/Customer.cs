using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MedicalStore.Core.Domain.Accounting;
using MedicalStore.Core.Domain.Common;
using MedicalStore.Core.Domain.Invoices;
using MedicalStore.Core.Domain.Orders;
using MedicalStore.Core.Domain.Stores;

namespace MedicalStore.Core.Domain.Customers
{
    public class Customer: BaseEntity
    {
        /// <summary>
        /// The addresses
        /// </summary>
        private ICollection<Address> _addresses;
        /// <summary>
        /// The roles
        /// </summary>
        private ICollection<Role> _roles;
        /// <summary>
        /// The orders
        /// </summary>
        private ICollection<Order> _orders;
        /// <summary>
        /// The invoices
        /// </summary>
        private ICollection<Invoice> _invoices;
        /// <summary>
        /// The payements
        /// </summary>
        private ICollection<Payement> _payements;
        /// <summary>
        /// The stores
        /// </summary>
        private ICollection<Store> _stores;


        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [Key]
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the pseudo.
        /// </summary>
        /// <value>
        /// The pseudo.
        /// </value>
        public string Pseudo { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

     /// <summary>
        /// Gets or sets the customer type identifier.
        /// </summary>
        /// <value>
        /// The customer type identifier.
        /// </value>
        public int? CustomerTypeId { get; set; }

        /// <summary>
        /// Gets or sets the customer debt.
        /// </summary>
        /// <value>
        /// The customer debt.
        /// </value>
        public decimal CustomerDebt { get; set; }

        /// <summary>
        /// Gets or sets the registration date.
        /// </summary>
        /// <value>
        /// The registration date.
        /// </value>
        public DateTime RegistrationDate { get; set; }


        /// <summary>
        /// Gets or sets the type of the customer.
        /// </summary>
        /// <value>
        /// The type of the customer.
        /// </value>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Gets or sets the customer status.
        /// </summary>
        /// <value>
        /// The customer status.
        /// </value>
        public CustomerStatus CustomerStatus { get; set; }

        /// <summary>
        /// Gets or sets the entreprise identifier.
        /// </summary>
        /// <value>
        /// The entreprise identifier.
        /// </value>
        //[ForeignKey("Entreprise")]
        //public int? EntrepriseId { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>

        public virtual ICollection<Address> Addresses
        {
            get { return _addresses ?? (_addresses = new List<Address>()); }
            protected set { _addresses = value; }
        }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        public virtual ICollection<Role> Roles
        {
            get { return _roles ?? (_roles = new List<Role>()); }
            protected set { _roles = value; }
        }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>
        /// The orders.
        /// </value>
        public ICollection<Order> Orders
        {
            get { return _orders ?? (_orders = new List<Order>()); }
            protected set { _orders = value; }
        }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        /// <value>
        /// The invoices.
        /// </value>
        public ICollection<Invoice> Invoices
        {
            get { return _invoices ?? (_invoices = new List<Invoice>()); }
            protected set { _invoices = value; }
        }

        /// <summary>
        /// Gets or sets the payements.
        /// </summary>
        /// <value>
        /// The payements.
        /// </value>
        public ICollection<Payement> Payements
        {
            get { return _payements ?? (_payements = new List<Payement>()); }
            protected set { _payements = value; }
        }

        /// <summary>
        /// Gets or sets the stores.
        /// </summary>
        /// <value>
        /// The stores.
        /// </value>
        public ICollection<Store> Stores
        {
            get { return _stores ?? (_stores = new List<Store>()); }
            protected set { _stores = value; }
        }

        /// <summary>
        /// Gets or sets the entreprise.
        /// </summary>
        /// <value>
        /// The entreprise.
        /// </value>
        //public Entreprise Entreprise { get; set; }

    }
}
