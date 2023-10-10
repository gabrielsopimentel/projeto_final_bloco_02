using FluentValidation;
using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(510);
            RuleFor(p => p.Quantidade)
                .NotEmpty();
            RuleFor(p => p.Preco)
                .NotNull()
                .GreaterThan(0)
                .PrecisionScale(6, 2, false);

        }
    }
}
