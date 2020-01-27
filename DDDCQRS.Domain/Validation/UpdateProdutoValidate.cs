using DDDCQRS.Domain.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Validation
{
    public class UpdateProdutoValidate : AllValidation<UpdateProductCommand>
    {
        public UpdateProdutoValidate()
        {
            ValidateName();
            ValidateFornecedor();
            ValidateValue();
            ValidateMarca();
        }
    }
}
