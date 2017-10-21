namespace MedicalStore.Core.Domain.Catalog
{
    public class Dosage
    {
        /// <summary>
        /// Gets or sets the dose.
        /// </summary>
       
        public int Dose { get; set; }

        /// <summary>
        /// Gets or sets the measure unit.
        /// </summary>
      
        public string MeasureUnit { get; set; }

        /// <summary>
        /// Gets the alias.
        /// </summary>
     
        public string Alias => Dose + " " + MeasureUnit;
    }
}
