using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Model.Construtora
{
    public partial class Material
    {
        public Guid IdMaterial { get; set; }
        public string NomeMaterial { get; set; }
        public int? TipoMaterial { get; set; }
        public int? QuantidadeMaterial { get; set; }
        public decimal? PrecoMaterial { get; set; }
        public int? ObraMaterial { get; set; }
        public string LocalCompraMaterial { get; set; }
        public DateTime? DataCompraMaterial { get; set; }
        public string ObservacaoMaterial { get; set; }
    }
}
