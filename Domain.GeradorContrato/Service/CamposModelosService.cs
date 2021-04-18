using AutoMapper;
using Domain.GeradorContrato.DTO.CamposModelos;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;

namespace Domain.GeradorContrato.Service
{
    public class CamposModelosService : ICamposModelosService
    {
        private readonly ICamposModelosImplementation _camposModelosImplementation;
        private readonly IMapper _mapper;

        public CamposModelosService(ICamposModelosImplementation camposModelosImplementation, IMapper mapper)
        {
            _camposModelosImplementation = camposModelosImplementation;
            _mapper = mapper;
        }

        public bool CriarCamposModelos(CriarCamposModelosDTO camposModelos)
        {
            var model = _mapper.Map<CamposModelosModel>(camposModelos);
            return _camposModelosImplementation.InsertAsync(model);
        }
    }
}
