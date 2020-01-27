using DDDCQRS.Domain.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Command
{
    public class UpdateProductCommand : CommandProduto, IRequest<bool>
    {
        public UpdateProductCommand(int identificador, string Nome, string Fornecedor, string Marca, decimal Valor)
        {
            id = identificador;
            nome = Nome;
            marca = Marca;
            fornecedor = Fornecedor;
            valor = Valor;
        }

        public override bool IsValid()
        {
            var ValidateUpdate = new UpdateProdutoValidate().Validate(this);
            return ValidateUpdate.IsValid;
        }
    }
}
