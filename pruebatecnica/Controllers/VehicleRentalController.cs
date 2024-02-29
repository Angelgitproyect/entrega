using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Service;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pruebatecnica.BaseController;
using pruebatecnica.Responses;

namespace pruebatecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleRentalController : BaseController<VehicleRental, VehicleRentalDto>
    {
        public readonly IVehicleRentalService _vehicleRentalService;
        public VehicleRentalController(
            IMapper mapper, 
            IVehicleRentalService vehicleRentalService, 
            IBaseService<VehicleRental> service) : base(mapper, service)
        {
            _vehicleRentalService = vehicleRentalService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ResponseGenericApi<VehicleRentalDto>>> GetAll()
        {
            var listVehicleRentalDto = _mapper.Map<IEnumerable<VehicleRentalDto>>(await _vehicleRentalService.Get());
            var response = new ResponseGenericApi<IEnumerable<VehicleRentalDto>>(listVehicleRentalDto);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ResponseGenericApi<VehicleRentalDto>>> GetByid([FromQuery] int idVehicleRental)
        {
            var VehicleRental = _mapper.Map<VehicleRentalDto>(await _vehicleRentalService.Get(idVehicleRental));
            var response = new ResponseGenericApi<VehicleRentalDto>(VehicleRental);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseGenericApi<VehicleRentalDto>>> Put([FromBody] VehicleRentalDto vehicleRentalDto)
        {
            await MapToEntityAsync(vehicleRentalDto);
            var VehicleRental = _mapper.Map<VehicleRentalDto>(await _vehicleRentalService.Put(_model));
            var response = new ResponseGenericApi<VehicleRentalDto>(VehicleRental);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseGenericApi<VehicleRentalDto>>> Post([FromBody] VehicleRentalDto vehicleRentalDto)
        {
            await MapToEntityAsync(vehicleRentalDto);
            var VehicleRental = _mapper.Map<VehicleRentalDto>(await _vehicleRentalService.Post(_model));
            var response = new ResponseGenericApi<VehicleRentalDto>(VehicleRental);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseGenericApi<VehicleRentalDto>>> Delete([FromBody] VehicleRentalDto vehicleRentalDto)
        {
            await MapToEntityAsync(vehicleRentalDto);
            return Ok(await _vehicleRentalService.Delete(_model));
        }
    }
}
