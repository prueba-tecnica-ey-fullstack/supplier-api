using AutoMapper;
using SuppliersManagement.Application.Interfaces;
using SuppliersManagement.Common.Entities;
using SuppliersManagement.Common.Exceptions;
using SuppliersManagement.Common.Response;
using SuppliersManagement.Domain.Dtos;
using SuppliersManagement.Domain.Entities;
using SuppliersManagement.Infrastructure.Repositories;

namespace SuppliersManagement.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<FindAllResponse<Supplier>> FindAllASync(FindQuery query)
        {
            return await _supplierRepository.GetAllAsync(query);
        }

        public async Task<Supplier> FindByIdAsync(int id)
        {
            Supplier supplier = await _supplierRepository.GetByIdAsync(id);

            if (supplier == null)
            {
                throw new NotFoundException("Supplier not found");
            }

            return supplier;
        }

        public async Task<Supplier> Create(SupplierDto supplierDto)
        {
            if (await _supplierRepository.ExistsByLegalNameAsync(supplierDto.LegalName))
            {
                throw new BadRequestException("Supplier with Legal Name already exists");
            }

            if (await _supplierRepository.ExistsByTaxIdentificationAsync(supplierDto.TaxIdentification))
            {
                throw new BadRequestException("Supplier with Tax Identification already exists");
            }

            Supplier supplier = _mapper.Map<Supplier>(supplierDto);
            supplier.CreatedDate = DateTime.Now;
            supplier.UpdatedDate = DateTime.Now;

            try
            {
                await _supplierRepository.AddAsync(supplier);
                return supplier;
            }
            catch (Exception ex)
            {
                throw new InternalServerException($"An error ocurred while saving: {ex.InnerException}");
            }
        }

        public async Task<Supplier> Delete(int id)
        {
            Supplier supplier = await _supplierRepository.GetByIdAsync(id);

            if (supplier == null)
            {
                throw new NotFoundException("Supplier not found");
            }

            try
            {
                await _supplierRepository.DeleteAsync(supplier);
                return supplier;
            }
            catch (Exception ex)
            {
                throw new InternalServerException($"An error ocurred while deleting: {ex.Message}");
            }
        }

        public async Task<Supplier> Update(int id, SupplierDto supplierDto)
        {
            Supplier supplier = await _supplierRepository.GetByIdAsync(id);

            if (supplier == null)
            {
                throw new NotFoundException("Supplier not found");
            }

            supplier.Name = supplierDto.Name;
            supplier.LegalName = supplierDto.LegalName;
            supplier.TaxIdentification = supplierDto.TaxIdentification;
            supplier.Phone = supplierDto.Phone;
            supplier.Email = supplierDto.Email;
            supplier.Website = supplierDto.Website;
            supplier.Address = supplierDto.Address;
            supplier.Country = supplierDto.Country;
            supplier.AnnualBilling = supplierDto.AnnualBilling;
            supplier.UpdatedDate = DateTime.Now;

            try
            {
                await _supplierRepository.UpdateAsync(supplier);
                return supplier;
            }
            catch (Exception ex)
            {
                throw new InternalServerException($"An error ocurred while updating: {ex.Message}");
            }

        }
    }
}
