using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using pruebatecnica.BaseController;
using pruebatecnica.Responses;

namespace pruebatecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationRentalController : BaseController<LocationRental, LocationRentalDto>
    {
        public readonly ILocationRentalService _locationRentalService;
        public LocationRentalController(
            IMapper mapper, 
            ILocationRentalService locationRentalService, 
            IBaseService<LocationRental> service) : base(mapper, service)
        {
            _locationRentalService = locationRentalService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ResponseGenericApi<LocationRentalDto>>> GetAll()
        {
            var listLocationRentalDto = _mapper.Map<IEnumerable<LocationRentalDto>>(await _locationRentalService.Get());
            var response = new ResponseGenericApi<IEnumerable<LocationRentalDto>>(listLocationRentalDto);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ResponseGenericApi<LocationRentalDto>>> GetByid([FromQuery] int idUser)
        {
            var LocationRental = _mapper.Map<LocationRentalDto>(await _locationRentalService.Get(idUser));
            var response = new ResponseGenericApi<LocationRentalDto>(LocationRental);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseGenericApi<LocationRentalDto>>> Put([FromBody] LocationRentalDto LocationRentalDto)
        {
            await MapToEntityAsync(LocationRentalDto);
            var LocationRental = _mapper.Map<LocationRentalDto>(await _locationRentalService.Put(_model));
            var response = new ResponseGenericApi<LocationRentalDto>(LocationRental);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseGenericApi<LocationRentalDto>>> Post([FromBody] LocationRentalDto LocationRentalDto)
        {
            await MapToEntityAsync(LocationRentalDto);
            var LocationRental = _mapper.Map<LocationRentalDto>(await _locationRentalService.Post(_model));
            var response = new ResponseGenericApi<LocationRentalDto>(LocationRental);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseGenericApi<LocationRentalDto>>> Delete([FromBody] LocationRentalDto LocationRentalDto)
        {
            await MapToEntityAsync(LocationRentalDto);
            return Ok(await _locationRentalService.Delete(_model));
        }
    }
}
