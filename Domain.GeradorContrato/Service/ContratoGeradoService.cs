using AutoMapper;
using Domain.GeradorContrato.DTO.ContratoGerado;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;

namespace Domain.GeradorContrato.Service
{
    public class ContratoGeradoService : IContratoGeradoService
    {
        private readonly IContratoGeradoImplementation _contratoGeradoImplementation;
        private readonly IMapper _mapper;

        public ContratoGeradoService(IContratoGeradoImplementation contratoGeradoImplementation, IMapper mapper)
        {
            _contratoGeradoImplementation = contratoGeradoImplementation;
            _mapper = mapper;
        }

        public bool CriarContratoGerado(CriarContratoGeradoDTO contratoGerado)
        {
            var model = _mapper.Map<ContratoGeradoModel>(contratoGerado);
            return _contratoGeradoImplementation.InsertAsync(model);
        }
    }
}
