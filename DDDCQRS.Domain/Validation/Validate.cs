using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Domain.Validation
{
    public abstract class Validate
    {
        public abstract bool IsValid();
    }
}
