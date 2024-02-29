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
    public class UserController : BaseController<User, UserDto>
    {
        public readonly IUserService _userService;
        public UserController(
            IMapper mapper, 
            IUserService userService, 
            IBaseService<User> service) : base(mapper, service)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ResponseGenericApi<UserDto>>> GetAll()
        {
            var listUserDto = _mapper.Map<IEnumerable<UserDto>>(await _userService.Get());
            var response = new ResponseGenericApi<IEnumerable<UserDto>>(listUserDto);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ResponseGenericApi<UserDto>>> GetByid([FromQuery] int idUser)
        {
            var User = _mapper.Map<UserDto>(await _userService.Get(idUser));
            var response = new ResponseGenericApi<UserDto>(User);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseGenericApi<UserDto>>> Put([FromBody] UserDto UserDto)
        {
            await MapToEntityAsync(UserDto);
            var User = _mapper.Map<UserDto>(await _userService.Put(_model));
            var response = new ResponseGenericApi<UserDto>(User);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseGenericApi<UserDto>>> Post([FromBody] UserDto UserDto)
        {
            await MapToEntityAsync(UserDto);
            var User = _mapper.Map<UserDto>(await _userService.Post(_model));
            var response = new ResponseGenericApi<UserDto>(User);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseGenericApi<UserDto>>> Delete([FromBody] UserDto UserDto)
        {
            await MapToEntityAsync(UserDto);
            return Ok(await _userService.Delete(_model));
        }
    }
}
