using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GeradorContrato.Model
{
    public class ModelBase
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
