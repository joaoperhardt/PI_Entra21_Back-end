using FluentValidation;
using PI_Entra21_Back_end.DTO;
namespace PI_Entra21_Back_end.Validator
{
    public class StoreValidator : AbstractValidator<StoreDTO>
    {
        public StoreValidator()
        {
            RuleFor(c => c.NAME).NotEmpty().WithMessage("O nome não pode estar vazio");

            RuleFor(c => c.CNPJ).NotEmpty().MinimumLength(14).WithMessage("O CNPJ deve conter 14 digitos");

            RuleFor(c => c.DESCRIPTION).NotEmpty().MinimumLength(4).WithMessage("A Descrição deve possuir 4 caracteres no mínimo.");

            RuleFor(c => c.CEP).NotEmpty().Length(8).WithMessage("Preencha o CEP, por gentileza.");

            RuleFor(c => c.DISTRICT).NotEmpty().WithMessage("Preencha o bairro, por gentileza.");

            RuleFor(c => c.STREET).NotEmpty().WithMessage("Preencha a rua, por gentileza.");

            RuleFor(c => c.COMPLEMENT).NotEmpty().WithMessage("Adicione um complemento");

            RuleFor(c => c.PHONE).NotEmpty().Length(11).WithMessage("Telefone deve conter exatamente 11 caracteres.");

            RuleFor(c => c.CPF).NotEmpty().Length(11).WithMessage("CPF deve conter 11 caracteres.");

        }
    }
}
