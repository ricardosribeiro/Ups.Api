using System;
using System.ComponentModel.DataAnnotations;
using Ups.Business.Enums;

namespace Ups.Api.ViewModels
{
    public class ImovelViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        [Required]
        public EImovelTipo Tipo { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        [Required]
        public decimal AreaTotal { get; set; }
        [Required]
        public int QtdeVagas { get; set; }
        [Required]
        public int QtdeQuartos { get; set; }
        [Required]
        public int QtdeBanheiros { get; set; }
        [Required]
        public bool PossuiSuite { get; set; }
        [Required]
        [StringLength(500,ErrorMessage ="O campo {0} deve ter entre {2} e {1} caracteres",MinimumLength =10)]
        public string Descricao { get; set; }

    }
}
