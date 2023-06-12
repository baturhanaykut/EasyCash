using EasyCash.DTOLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegistorDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Ad alanı boş geçilemez..");
            RuleFor(x => x.Surname)
                .NotEmpty()
                .WithMessage("Soyadı alanı boş geçilemez..");
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Kullanıcı Adı alanı boş geçilemez..");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email alanı boş geçilemez..");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre alanı boş geçilemez..");
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .WithMessage("Şifre tekrar alanı boş geçilemez..");

            RuleFor(x => x.Name)
                .MaximumLength(30)
                .WithMessage("Lütfen en fazla 30 karakter girişi yapın");   
            RuleFor(x => x.Name)
                .MinimumLength(2)
                .WithMessage("Lütfen en az 2 karakter girişi yapın");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız eşleşmiyor");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");

        }


    }
}
