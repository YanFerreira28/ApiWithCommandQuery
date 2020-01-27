using DDDCQRS.Domain.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Command
{
    public class DeleteProductCommand : CommandProduto, IRequest<bool>
    {
        public DeleteProductCommand(int identificador)
        {
            id = identificador;
        }

        public override bool IsValid()
        {
            var ValidateId = new DeleteProdutoValidate().Validate(this);
            return ValidateId.IsValid;
        }

    }
}
