using Domain.GeradorContrato.DTO.CamposModelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Interface.Service
{
    public interface ICamposModelosService
    {
        bool CriarCamposModelos(CriarCamposModelosDTO camposModelos);
    }
}
