using Domain.GeradorContrato.DTO.ModeloContrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Interface.Service
{
    public interface IModeloContratoService
    {
        bool CriarModeloContrato(CriarModeloContratoDTO modeloContrato);
    }
}