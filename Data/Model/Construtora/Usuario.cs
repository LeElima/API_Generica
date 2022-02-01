using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Model.Construtora
{
    public partial class Usuario
    {
        public Guid IdUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public bool? Excluido { get; set; }
        public int? PrivilegioUsuario { get; set; }
    }
}
