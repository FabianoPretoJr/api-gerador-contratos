using Domain.GeradorContrato.DTO.ValoresCampos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Interface.Service
{
    public interface IValoresCamposService
    {
        bool CriarValoresCampos(CriarValoresCamposDTO valoresCampos);
    }
}
