using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class ContratoGeradoModel : ModelBase
    {
        public int Id_ModeloContrato { get; set; }
        public virtual ModeloContratoModel ModeloContrato { get; set; }
        public int Id_Usuario { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<ValoresCamposModel> ValoresCampos { get; set; }
    }
}
