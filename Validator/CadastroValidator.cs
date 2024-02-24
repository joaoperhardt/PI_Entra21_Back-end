﻿using FluentValidation;
using PI_Entra21_Back_end.DTO;
namespace PI_Entra21_Back_end.Validator
{
    public class CadastroValidator : AbstractValidator<UserDTO>
    {
        public CadastroValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("O nome não pode estar vazio");

            RuleFor(c => c.Cep).NotEmpty()
                .Length(8).WithMessage("o cep deve conter 8 digitos");

            RuleFor(c => c.Password).NotEmpty()
                .MinimumLength(4).WithMessage("Password deve conter no mínimo 4 caracteres.");

            RuleFor(c => c.Phone).NotEmpty()
                .Length(11).WithMessage("Telefone deve conter exatamente 11 caracteres.");

            RuleFor(c => c.Email).NotEmpty().WithMessage("Você deve preencher o campo e-mail.")
                .When(c => !string.IsNullOrWhiteSpace(c.Email))
                .Must(c => c.Contains("@"))
                .WithMessage("O campo e-mail deve conter o caracter '@' ");

            RuleFor(c => c.BirthDate).NotEmpty().WithMessage("Você deve preencher o campo data de nascimento")
                .Must(MaiorIdade).WithMessage("Você deve ter pelo menos 18 anos para criar uma conta.");
        }
        private bool MaiorIdade(DateTime nascimento)
        {
            if (nascimento == DateTime.MinValue) return false;

            var idade = DateTime.Today.Year - nascimento.Year;

            if (nascimento.Date > DateTime.Today.AddYears(-idade))
                idade--;

            return idade >= 18;
        }
    }
}
