using AutoMapper;
using Domain.GeradorContrato.DTO.CamposModelos;
using Domain.GeradorContrato.DTO.ContratoGerado;
using Domain.GeradorContrato.DTO.ModeloContrato;
using Domain.GeradorContrato.DTO.Usuario;
using Domain.GeradorContrato.DTO.ValoresCampos;
using Domain.GeradorContrato.Model;

namespace Domain.GeradorContrato.Mapper
{
    public class ModelToDTO : Profile
    {
        public ModelToDTO()
        {
            CreateMap<ModeloContratoModel, CriarModeloContratoDTO>()
                .ReverseMap();

            CreateMap<CamposModelosModel, CriarCamposModelosDTO>()
                .ReverseMap();

            CreateMap<UsuarioModel, CadastrarUsuarioDTO>()
                .ReverseMap();

            CreateMap<ContratoGeradoModel, CriarContratoGeradoDTO>()
                .ReverseMap();

            CreateMap<ValoresCamposModel, CriarValoresCamposDTO>()
                .ReverseMap();
        }
    }
}
