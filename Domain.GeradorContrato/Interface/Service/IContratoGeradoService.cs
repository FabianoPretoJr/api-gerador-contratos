using Domain.GeradorContrato.DTO.ContratoGerado;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Interface.Service
{
    public interface IContratoGeradoService
    {
        bool CriarContratoGerado(CriarContratoGeradoDTO contratoGerado);
    }
}
