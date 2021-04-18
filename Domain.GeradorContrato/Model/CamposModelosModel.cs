using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class CamposModelosModel : ModelBase
    {
        public string Nome_Campo { get; set; }
        public string Tipo_Campo { get; set; }
        public int Id_ModeloContrato { get; set; }
        public virtual ModeloContratoModel ModeloContrato { get; set; }
        public virtual ICollection<ValoresCamposModel> ValoresCampos { get; set; }
    }
}
