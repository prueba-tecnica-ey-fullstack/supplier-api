using SuppliersManagement.Common.Entities;
using SuppliersManagement.Domain.Entities;

namespace SuppliersManagement.Infrastructure.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetAllAsync(FindQuery query);
        Task<Supplier> GetByIdAsync(int id);
        Task AddAsync(Supplier supplier);
        Task UpdateAsync(Supplier supplier);
        Task DeleteAsync(Supplier supplier);
        Task<bool> ExistsByTaxIdentificationAsync(string taxIdentification);
        Task<bool> ExistsByLegalNameAsync(string legalName);
    }
}
