using AutoMapper;
using SuppliersManagement.Domain.Dtos;
using SuppliersManagement.Domain.Entities;

namespace SuppliersManagement.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierDto, Supplier>();
        }

    }
}
