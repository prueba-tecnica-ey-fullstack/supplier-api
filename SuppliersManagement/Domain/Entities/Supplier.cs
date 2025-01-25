namespace SuppliersManagement.Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LegalName { get; set; } = string.Empty;
        public string TaxIdentification { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public double AnnualBilling { get; set; } = 0;

    }
}
