using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using pruebatecnica.BaseController;
using pruebatecnica.Responses;

namespace pruebatecnica.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarsController : BaseController<Cars, CarsDto>
    {
        protected readonly IHttpContextAccessor _accessor;
        public readonly ICarsService _carsService;
        public CarsController(
            IMapper mapper, 
            ICarsService carsService,
            IBaseService<Cars> service, 
            IHttpContextAccessor asccessor) : base(mapper, service)
        {
            _carsService = carsService; 
            _accessor = asccessor;  
        }

        [HttpGet]
        [Route("VehicleAvailable")]
        public async Task<ActionResult<ResponseGenericApi<CarsDto>>> VehicleAvailable([FromQuery] SearchVehicleDto searchVehicleDto)
        {
            var carsDto = _mapper.Map<IEnumerable<CarsDto>>(await _carsService.VehicleAvailable(searchVehicleDto, _accessor));
            var response = new ResponseGenericApi<IEnumerable<CarsDto>>(carsDto);
            return Ok(response);
        }
    }
}
