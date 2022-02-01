using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Model.Construtora
{
    public partial class Obra
    {
        public Guid IdObra { get; set; }
        public string NomeObra { get; set; }
        public string RuaObra { get; set; }
        public int? NumeroObra { get; set; }
        public int? CidadeObra { get; set; }
        public int? EstadoObra { get; set; }
        public bool? Excluido { get; set; }
    }
}
