using EFCore.Models;
using FluentValidation;

namespace EFCore.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("AAA");
            RuleFor(x => x.LastName).NotNull().WithMessage("Last Name is required");
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x => x.Height).ScalePrecision(1, 3);
            RuleFor(x => x.Age).InclusiveBetween(18, 50).WithMessage("Enter valid age");            
            RuleFor(x => x.Phone)
                .Must(phone => !string.IsNullOrEmpty(phone) && phone.StartsWith("+"))
                .WithMessage("Phone must starts with + sign");

            RuleFor(x => x.PrimaryAddress).InjectValidator();
            //RuleFor(x => x.PrimaryAddress).SetValidator(new AddressValidator());
        }
    }
}