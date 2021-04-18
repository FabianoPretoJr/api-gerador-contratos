using AutoMapper;
using Domain.GeradorContrato.DTO.ValoresCampos;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;

namespace Domain.GeradorContrato.Service
{
    public class ValoresCamposService : IValoresCamposService
    {
        private readonly IValoresCamposImplementation _valoresCamposImplementation;
        private readonly IMapper _mapper;

        public ValoresCamposService(IValoresCamposImplementation valoresCamposImplementation, IMapper mapper)
        {
            _valoresCamposImplementation = valoresCamposImplementation;
            _mapper = mapper;
        }

        public bool CriarValoresCampos(CriarValoresCamposDTO valoresCampos)
        {
            var model = _mapper.Map<ValoresCamposModel>(valoresCampos);
            return _valoresCamposImplementation.InsertAsync(model);
        }
    }
}
