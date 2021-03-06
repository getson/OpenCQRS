﻿using Kledex.Commands;
using System.Threading.Tasks;

namespace Kledex.Validation
{
    public interface IValidationService
    {
        /// <summary>Validates the command asynchronously.</summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        Task ValidateAsync(ICommand command);

        /// <summary>Validates the command.</summary>
        /// <param name="command">The command.</param>
        void Validate(ICommand command);
    }
}
