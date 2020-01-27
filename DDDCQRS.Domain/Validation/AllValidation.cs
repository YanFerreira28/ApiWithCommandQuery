using DDDCQRS.Domain.Command;
using FluentValidation;

namespace DDDCQRS.Domain.Validation
{
    public abstract class AllValidation<T> : AbstractValidator<T> where T : CommandProduto 
    {
        protected void ValidateName()
        {
            RuleFor(c => c.nome).NotEmpty().WithMessage("Favor insira um nome ao campo")
                .MaximumLength(50);
        }

        protected void ValidateValue()
        {
            RuleFor(c => c.valor).NotEmpty().WithMessage("Favor insira um valor ao campo");

        }

        protected void ValidateMarca()
        {
            RuleFor(c => c.marca).NotEmpty().WithMessage("Favor insira uma marca ao campo")
                .MaximumLength(50);
        }
        protected void ValidateFornecedor()
        {
            RuleFor(c => c.fornecedor).NotEmpty().WithMessage("Favor insira um fornecedor ao campo")
                .MaximumLength(50);
        }

        protected void ValidateID()
        {
            RuleFor(c => c.id).Empty().WithMessage("Verifique o ID");
        }
    }
}
