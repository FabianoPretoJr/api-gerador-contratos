using AutoMapper;
using Domain.GeradorContrato.DTO.Usuario;
using Domain.GeradorContrato.Interface.Service;
using Domain.GeradorContrato.Model;
using Domain.GeradorContrato.Repository;

namespace Domain.GeradorContrato.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioImplementation _usuarioImplementation;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioImplementation usuarioImplementation, IMapper mapper)
        {
            _usuarioImplementation = usuarioImplementation;
            _mapper = mapper;
        }

        public bool CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);
            return _usuarioImplementation.InsertAsync(model);
        }
    }
}
