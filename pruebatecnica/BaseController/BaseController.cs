using AutoMapper;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace pruebatecnica.BaseController
{
    public class BaseController<TEntity, TEntityDto> : ControllerBase where TEntity : class
    {
        protected readonly IMapper _mapper;
        protected readonly IBaseService<TEntity> _service;
        
        protected TEntity _model { get; set; }
        protected TEntityDto _dtoModel { get; set; }

        public BaseController(IMapper mapper ,IBaseService<TEntity> service)
        {
            _mapper = mapper;
            _service = service;
        }
        protected async Task MapToEntityAsync(TEntityDto dtoEntity)
        {
            _model = _mapper.Map<TEntity>(dtoEntity);
        }
        protected void MapToDto()
        {
            _dtoModel = _mapper.Map<TEntityDto>(_model);
        }

    }
}
