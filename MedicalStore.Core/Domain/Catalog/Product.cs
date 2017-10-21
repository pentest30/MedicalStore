using System.Collections.Generic;

namespace MedicalStore.Core.Domain.Catalog
{
    public partial class Product:BaseEntity
    {
        /// <summary>
        /// The product stocks
        /// </summary>
        private ICollection<ProductStock> _productStocks;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
      
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
    
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the full description.
        /// </summary>
      
        public string FullDescription { get; set; }

        /// <summary>
        /// Gets or sets the manifacturer identifier.
        /// </summary>
      
        public int ManifacturerId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
     
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the product form identifier.
        /// </summary>
     
        public int ProductFormId { get; set; }

        /// <summary>
        /// Gets or sets the dosage identifier.
        /// </summary>
       
        public int DosageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is refundable.
        /// </summary>
      
        public bool IsRefundable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [track stock].
        /// </summary>
      
        public bool TrackStock { get; set; }

        /// <summary>
        /// Gets or sets the minimum QNT stock.
        /// </summary>
      
        public int? MinQntStock { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
       
        public Category Category { get; set; }

        /// <summary>
        /// Gets or sets the manifacturer.
        /// </summary>
     
        public Manifacturer Manifacturer { get; set; }

        /// <summary>
        /// Gets or sets the product form.
        /// </summary>
       
        public ProductForm ProductForm { get; set; }

        /// <summary>
        /// Gets or sets the dosage.
        /// </summary>
       
        public Dosage Dosage { get; set; }

        /// <summary>
        /// Gets or sets the conditioning.
        /// </summary>
      
        public Conditioning Conditioning { get; set; }

        /// <summary>
        /// Gets or sets the product stocks.
        /// </summary>
       
      
        public ICollection<ProductStock> ProductStocks
        {
            get => _productStocks ?? (_productStocks = new List<ProductStock>());
            protected set => _productStocks = value;
        }

    }
}
