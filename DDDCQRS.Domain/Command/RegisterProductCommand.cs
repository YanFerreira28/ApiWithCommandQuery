using DDDCQRS.Domain.Entities;
using DDDCQRS.Domain.Validation;
using MediatR;

namespace DDDCQRS.Domain.Command
{
    public class RegisterProductCommand : CommandProduto, IRequest<bool>
    {
        public RegisterProductCommand(string Nome, string Fornecedor, string Marca, decimal Valor)
        {
            nome = Nome;
            fornecedor = Fornecedor;
            marca = Marca;
            valor = Valor;
        }

        public override bool IsValid()
        {
            var validationResult = new RegisterProdutoValidate().Validate(this);
            return validationResult.IsValid;
        }



    }
}
