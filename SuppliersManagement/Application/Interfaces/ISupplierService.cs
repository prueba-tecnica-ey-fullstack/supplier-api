using SuppliersManagement.Common.Entities;
using SuppliersManagement.Common.Response;
using SuppliersManagement.Domain.Dtos;
using SuppliersManagement.Domain.Entities;

namespace SuppliersManagement.Application.Interfaces
{
    public interface ISupplierService
    {
        Task<FindAllResponse<Supplier>> FindAllASync(FindQuery query);
        Task<Supplier> FindByIdAsync(int id);
        Task<Supplier> Create(SupplierDto supplierDto);
        Task<Supplier> Update(int id, SupplierDto supplierDto);
        Task<Supplier> Delete(int id);
    }
}
