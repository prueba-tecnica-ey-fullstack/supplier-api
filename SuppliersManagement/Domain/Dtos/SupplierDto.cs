using System.ComponentModel.DataAnnotations;

namespace SuppliersManagement.Domain.Dtos
{
    public class SupplierDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LegalName { get; set; } = string.Empty;

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string TaxIdentification { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Website { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;

        [Required]
        public double AnnualBilling { get; set; } = 0;
    }
}
