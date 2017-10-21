namespace MedicalStore.Core.Domain.Providers
{
    public partial class Provider:BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the tel.
        /// </summary>
      
        public string Tel { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
     
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

    }
}
