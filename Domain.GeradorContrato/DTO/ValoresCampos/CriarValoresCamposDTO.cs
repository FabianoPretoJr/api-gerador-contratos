using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.DTO.ValoresCampos
{
    public class CriarValoresCamposDTO
    {
        public string Valor_Campo { get; set; }
        public int Id_CamposModelos { get; set; }
        public int Id_ContratoGerado { get; set; }
    }
}
