using Domain.GeradorContrato.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Interface.Service
{
    public interface  IUsuarioService
    {
        bool CadastrarUsuario(CadastrarUsuarioDTO usuario);
    }
}
