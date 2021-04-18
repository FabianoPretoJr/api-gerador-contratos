using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class ValoresCamposModel : ModelBase
    {
        public string Valor_Campo { get; set; }
        public int Id_CamposModelos { get; set; }
        public virtual CamposModelosModel CamposModelos { get; set; }
        public int Id_ContratoGerado { get; set; }
        public virtual ContratoGeradoModel ContratoGerado { get; set; }
    }
}
