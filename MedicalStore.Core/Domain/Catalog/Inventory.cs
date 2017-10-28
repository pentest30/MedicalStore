using System;
using MedicalStore.Core.Domain.Providers;
using MedicalStore.Core.Domain.Stores;

namespace MedicalStore.Core.Domain.Catalog
{
    public partial class Inventory
    {
        /// <summary>
        /// Gets or sets the stock identifier.
        /// </summary>
        /// <value>
        /// The stock identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the store identifier.
        /// </summary>
        /// <value>
        /// The store identifier.
        /// </value>
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets the production batch.
        /// </summary>
        /// <value>
        /// The production batch.
        /// </value>
     
        public decimal SalePriceUnit { get; set; }

        /// <summary>
        /// Gets or sets the benefit rate.
        /// </summary>
        /// <value>
        /// The benefit rate.
        /// </value>
        public decimal BenefitRate { get; set; }

        /// <summary>
        /// Gets the buy unit price.
        /// </summary>
        /// <value>
        /// The buy unit price.
        /// </value>
        public decimal BuyUnitPrice
        {
            get { return SalePriceUnit + (SalePriceUnit * BenefitRate / 100); }
        }

        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        public int? ProviderId { get; set; }

       /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the store.
        /// </summary>
        /// <value>
        /// The store.
        /// </value>
        public Store Store { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the on created.
        /// </summary>
        /// <value>
        /// The on created.
        /// </value>
        public DateTime OnCreated { get; set; }

        /// <summary>
        /// Gets or sets the on arrival.
        /// </summary>
        /// <value>
        /// The on arrival.
        /// </value>
        public DateTime OnArrival { get; set; }
        /// <summary>
        /// N° de lot.
        /// </summary>
        /// <value>
        /// The batch number.
        /// </value>
        public string BatchNumber { get; set; }

        /// <summary>
        /// Gets or sets the production date.
        /// </summary>
        /// <value>
        /// The production date.
        /// </value>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public DateTime ExpirationDate { get; set; }

    }
}
