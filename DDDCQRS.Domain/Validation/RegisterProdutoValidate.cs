using DDDCQRS.Domain.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Validation
{
    public class RegisterProdutoValidate : AllValidation<RegisterProductCommand>
    {
        public RegisterProdutoValidate()
        {
            ValidateName();
            ValidateMarca();
            ValidateFornecedor();
            ValidateValue();
        }
    }
}
