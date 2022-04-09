using EFCore.Models;
using FluentValidation;

namespace EFCore.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.AddressLine1).NotNull().NotEmpty();
            RuleFor(x => x.Country).NotNull().NotEmpty();
            RuleFor(x => x.State).NotNull().NotEmpty();
            RuleFor(x => x.PostalCode).NotNull().NotEmpty();
        }
    }
}
