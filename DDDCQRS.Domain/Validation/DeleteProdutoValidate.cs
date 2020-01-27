using DDDCQRS.Domain.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Validation
{
    public class DeleteProdutoValidate : AllValidation<DeleteProductCommand>
    {
        public DeleteProdutoValidate()
        {
            ValidateID();
        }
    }
}
