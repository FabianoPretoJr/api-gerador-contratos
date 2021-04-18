using AutoMapper;
using Domain.GeradorContrato.DTO.ModeloContrato;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;

namespace Domain.GeradorContrato.Service
{
    public class ModeloContratoService : IModeloContratoService
    {
        private readonly IModeloContratoImplementation _modeloContratoImplementation;
        private readonly IMapper _mapper;

        public ModeloContratoService(IModeloContratoImplementation modeloContratoImplementation, IMapper mapper)
        {
            _modeloContratoImplementation = modeloContratoImplementation;
            _mapper = mapper;
        }

        public bool CriarModeloContrato(CriarModeloContratoDTO modeloContrato)
        {
            var model = _mapper.Map<ModeloContratoModel>(modeloContrato);
            return _modeloContratoImplementation.InsertAsync(model);
        }
    }
}
