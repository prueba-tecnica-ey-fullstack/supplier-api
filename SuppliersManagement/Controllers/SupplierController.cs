using Microsoft.AspNetCore.Mvc;
using SuppliersManagement.Application.Interfaces;
using SuppliersManagement.Common.Entities;
using SuppliersManagement.Domain.Dtos;
using SuppliersManagement.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace SuppliersManagement.Controllers
{
    [ApiController]
    [SwaggerTag("suppliers")]
    [Route("api/suppliers")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieves all suppliers",
            Description = "Returns a list of all suppliers available in the system."
        )]
        [SwaggerResponse(200, "Successfully retrieved the list of suppliers.")]
        public async Task<IEnumerable<Supplier>> FindAll([FromQuery] FindQuery query)
        {
            return await _supplierService.FindAllASync(query);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieve a supplier by ID",
            Description = "Returns the supplier information matching the given ID."
        )]
        [SwaggerResponse(200, "Successfully retrieved the supplier.")]
        [SwaggerResponse(404, "The supplier with the given ID was not found.")]
        public async Task<Supplier> FindById(int id)
        {
            return await _supplierService.FindByIdAsync(id);
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new supplier",
            Description = "Adds a new supplier to the system."
        )]
        [SwaggerResponse(201, "The supplier was created successfully.")]
        [SwaggerResponse(400, "Invalid supplier data provided.")]
        public async Task<Supplier> Create([FromBody] SupplierDto dto)
        {
            return await _supplierService.Create(dto);
        }

        [HttpPatch("{id}")]
        [SwaggerOperation(
            Summary = "Update an existing supplier",
            Description = "Updates the details of an existing supplier."
        )]
        [SwaggerResponse(200, "The supplier was updated successfully.")]
        [SwaggerResponse(404, "The supplier with the given ID was not found.")]
        public async Task<Supplier> Update(int id, [FromBody] SupplierDto dto)
        {
            return await _supplierService.Update(id, dto);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete a supplier",
            Description = "Deletes a supplier from the system using the given ID."
        )]
        [SwaggerResponse(200, "The supplier was deleted successfully.")]
        [SwaggerResponse(404, "The supplier with the given ID was not found.")]
        public async Task<Supplier> Delete(int id)
        {
            return await _supplierService.Delete(id);
        }
    }
}
