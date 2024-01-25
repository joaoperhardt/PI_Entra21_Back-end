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
        }
    }
}
