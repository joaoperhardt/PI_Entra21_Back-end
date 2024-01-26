using FluentValidation;
using PI_Entra21_Back_end.DTO;
namespace PI_Entra21_Back_end.Validator
{
    public class CadastroValidator : AbstractValidator<CadastroUserDTO>
    {
        public CadastroValidator() 
        {
            RuleFor( c => c.Name ) .NotEmpty().WithMessage("O nome não pode estar vazio") ;
            
            RuleFor(c => c.Cep).NotEmpty().Length(8).WithMessage("o cep deve conter 8 digitos");

            RuleFor(c => c.Password).NotEmpty().MinimumLength(4).WithMessage("Password deve conter no mínimo 4 caracteres.");

            RuleFor(c => c.Phone).NotEmpty().Length(11).WithMessage("Telefone deve conter exatamente 11 caracteres.");

            RuleFor(c => c.)
        }
    }
}
