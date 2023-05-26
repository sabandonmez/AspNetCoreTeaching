using OrnekProje.Models.ModelMetadataType;
using System.ComponentModel.DataAnnotations;

namespace OrnekProje.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }
        public string Email { get; set; }
        
    }
}
