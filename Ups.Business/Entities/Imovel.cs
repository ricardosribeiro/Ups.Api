using System;
using System.Collections.Generic;
using System.Text;

namespace Ups.Business.Entities
{
    public class Imovel : Entity
    {
        public DateTime DataCadastro { get; set; }
        public EImovelTipo Tipo { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        public decimal AreaTotal { get; set; }
        public int QtdeVagas { get; set; }
        public int QtdeQuartos { get; set; }
        public int QtdeBanheiro { get; set; }
        public bool PossuiSuite { get; set; }
        public string Descricao { get; set; }


    }
}
