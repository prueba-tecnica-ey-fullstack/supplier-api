using Microsoft.EntityFrameworkCore;
using SuppliersManagement.Common.Entities;
using SuppliersManagement.Domain.Entities;
using SuppliersManagement.Infrastructure.Contexts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SuppliersManagement.Infrastructure.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync(FindQuery query)
        {
            var suppliersQuery = _context.Suppliers.AsQueryable();


            if (!string.IsNullOrEmpty(query.Name))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Name.Contains(query.Name));
            }

            if (!string.IsNullOrEmpty(query.LegalName))
            {
                suppliersQuery = suppliersQuery.Where(s => s.LegalName.Contains(query.LegalName));
            }

            if (!string.IsNullOrEmpty(query.TaxIdentification))
            {
                suppliersQuery = suppliersQuery.Where(s => s.TaxIdentification.Contains(query.TaxIdentification));
            }

            if (!string.IsNullOrEmpty(query.Phone))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Phone.Contains(query.Phone));
            }

            if (!string.IsNullOrEmpty(query.Email))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Email.Contains(query.Email));
            }

            if (!string.IsNullOrEmpty(query.Website))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Website.Contains(query.Website));
            }

            if (!string.IsNullOrEmpty(query.Address))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Address.Contains(query.Address));
            }

            if (!string.IsNullOrEmpty(query.Country))
            {
                suppliersQuery = suppliersQuery.Where(s => s.Country.Contains(query.Country));
            }


            if (!string.IsNullOrEmpty(query.Sort))
            {
                var normalizedSort = char.ToUpper(query.Sort[0]) + query.Sort.Substring(1);

                suppliersQuery = query.Order?.ToLower() == "desc"
                    ? suppliersQuery.OrderByDescending(s => EF.Property<object>(s, normalizedSort))
                    : suppliersQuery.OrderBy(s => EF.Property<object>(s, normalizedSort));
            }
            else
            {
                suppliersQuery = suppliersQuery.OrderByDescending(s => s.UpdatedDate);
            }

            return await suppliersQuery.ToListAsync();

        }

        public async Task<Supplier> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }

        public async Task AddAsync(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Supplier supplier)
        {
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }

        public Task<bool> ExistsByTaxIdentificationAsync(string taxIdentification)
        {
            return _context.Suppliers.AnyAsync(s => s.TaxIdentification.Equals(taxIdentification));
        }

        public Task<bool> ExistsByLegalNameAsync(string legalName)
        {
            return _context.Suppliers.AnyAsync(s => s.LegalName.Equals(legalName));
        }
    }
}
