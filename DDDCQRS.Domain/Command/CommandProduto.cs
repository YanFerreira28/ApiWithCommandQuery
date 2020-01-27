using DDDCQRS.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Command
{
    public abstract class CommandProduto : Validate
    {
        public int id { get; protected set; }

        public string nome { get; protected set; }

        public string fornecedor { get; protected set; }

        public string marca { get; protected set; }

        public decimal valor { get; protected set; }
        
    }
}
