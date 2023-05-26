using System.ComponentModel.DataAnnotations;

namespace OrnekProje.Models.ModelMetadataType
{
    public class ProductMetadata
    {

        [Required(ErrorMessage = "Lütfen ProductName'i giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen ProductName ' i en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen Doğru Bir Mail Adresi Giriniz.")]
        public int Email { get; set; }

    }
}
