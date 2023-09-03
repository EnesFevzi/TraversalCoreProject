﻿using FluentValidation;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("lütfen 30 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("lütfen 8 karakterden daha uzun bir isim giriniz");
        }
    }
}
