using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class ModeloContratoModel : ModelBase
    {
        public string Nome { get; set; }
        public virtual ICollection<CamposModelosModel> CamposModelos { get; set; }
        public virtual ICollection<ContratoGeradoModel> ContratoGerado { get; set; }
    }
}
