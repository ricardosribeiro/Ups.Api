using FluentValidation;

namespace Ups.Business.Entities.Validacoes
{
    public class ImovelValidation: AbstractValidator<Imovel>
    {
        public ImovelValidation()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("O campo {} precisa ser fornecido")
                .Length(2, 500).WithMessage("O campo {} precisa ter entre {} e {} caracteres");

            RuleFor(c => c.AreaTotal)                
                .GreaterThan(0).WithMessage("O valor do campo {} precisa ser maior que {}");

            RuleFor(c => c.QtdeBanheiros)
                .GreaterThanOrEqualTo(0).WithMessage("O valor do campo {} precisa ser maior ou igual a {}");

            RuleFor(c => c.QtdeQuartos)
                .GreaterThanOrEqualTo(0).WithMessage("O valor do campo {} precisa ser maior ou igual a {}");

            RuleFor(c => c.QtdeVagas)
                .GreaterThanOrEqualTo(0).WithMessage("O valor do campo {} precisa ser maior ou igual a {}");

            RuleFor(c => c.Tipo).IsInEnum().WithMessage("Tipo de imóvel inválido");

            RuleFor(c => c.PossuiSuite).NotNull().WithMessage("O campo {} é obrigatório");       



        }
    }
}
