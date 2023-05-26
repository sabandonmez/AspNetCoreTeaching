using FluentValidation;

namespace OrnekProje.Models.Validatiors
{
    public class ProductValidatior : AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Lütfen ProductName'i boş geçmeyiniz");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("100 karakterden fazla karakter giremzssiniz");

            RuleFor(x => x.Email).NotNull().WithMessage("EMail'i boş geçmeyiniz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("EMail'i uygun formatta yazınız. ");
        }


    }
}
