using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class UsuarioModel : ModelBase
    {
        public string User_Login { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<ContratoGeradoModel> ContratoGerado { get; set; }
    }
}
