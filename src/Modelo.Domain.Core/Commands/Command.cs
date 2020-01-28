using System;
using System.Collections.Generic;
using System.Text;
using Modelo.Domain.Core.Events;
using FluentValidation.Results;
using System.Threading.Tasks;

namespace Modelo.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command(string messageType) : base(messageType)
        {
        }

        protected Command()
        {
        }

        public ValidationResult ValidationResult { get; set; }

        public abstract Task<bool> IsValid();
    }
}
