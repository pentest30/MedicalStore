using System;
using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Catalog
{
    public class ProductionBatch:BaseEntity
    {
        private ICollection<ProductStock> _productStocks;

       

        /// <summary>
        /// Gets or sets the product stocks.
        /// </summary>
        /// <value>
        /// The product stocks.
        /// </value>
        public ICollection<ProductStock> ProductStocks
        {
            get => _productStocks ?? (_productStocks = new List<ProductStock>());
            protected set => _productStocks = value;
        }

        
    }
}
