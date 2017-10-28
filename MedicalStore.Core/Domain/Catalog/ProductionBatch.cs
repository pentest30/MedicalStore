using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Catalog
{
    public class ProductionBatch:BaseEntity
    {
        private ICollection<Inventory> _productStocks;

       

        /// <summary>
        /// Gets or sets the product stocks.
        /// </summary>
        /// <value>
        /// The product stocks.
        /// </value>
        public ICollection<Inventory> ProductStocks
        {
            get { return _productStocks ?? (_productStocks = new List<Inventory>()); }
            protected set { _productStocks = value; }
        }
    }
}
