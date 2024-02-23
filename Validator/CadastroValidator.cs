using FluentValidation;
using PI_Entra21_Back_end.DTO;
namespace PI_Entra21_Back_end.Validator
{
    public class CadastroValidator : AbstractValidator<UserDTO>
    {
        public CadastroValidator() 
        {
            RuleFor( c => c.Name ) .NotEmpty().WithMessage("O nome não pode estar vazio") ;
        }
    }
}
