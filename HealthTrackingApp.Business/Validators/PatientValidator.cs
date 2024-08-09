using FluentValidation;
using HealthTrackingApp.Entity.Models;

namespace HealthTrackingApp.Business.Validators;

public class PatientValidator : AbstractValidator<Patient>
{
    public PatientValidator()
    {
        RuleFor(p => p.FullName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.")
            .MinimumLength(4).WithMessage("İsim uzunluğu 4 karakterden kısa olamaz.");

        RuleFor(p => p.SSN).NotEmpty().WithMessage("TC Kimlik Numarası boş olamaz.")
            .Length(11).WithMessage("TC Kimlik Numarası 11 haneli olmalıdır.")
            .Matches("[0-9]").WithMessage("TC Kimlik Numarası rakamlardan oluşmalıdır.");

        RuleFor(p => p.Email)
            .EmailAddress().WithMessage("Geçersiz e-posta formatı.")
            .MaximumLength(100).WithMessage("E-posta 100 karakterden uzun olamaz.")
            .Must(email => email.EndsWith(".com")).WithMessage("E-posta adresi .com ile bitmelidir.");

        RuleFor(g => g.Phone)
            .Matches(@"^\d{10}$").WithMessage("Telefon numarası 10 haneli olmalıdır.");

        RuleFor(p => p.BirthDate)
            .LessThan(DateTime.Today).WithMessage("Doğum tarihi geçmişte olmalıdır.");

        RuleFor(p => p.Address).NotEmpty().WithMessage("Lütfen adres bilgisini giriniz.")
            .MaximumLength(100).WithMessage("Adres 100 karakterden uzun olamaz.");

        RuleFor(p => p.Gender).NotEmpty().WithMessage("Lütfen cinsiyeti giriniz.");

        RuleFor(p => p.MedicalHistory).MaximumLength(400).WithMessage("Tibbi geçmiş alanı 400 karakteri geçmemelidir.");

        RuleFor(p => p.MaritalStatus).NotEmpty().WithMessage("Lütfen medeni hali giriniz.");

        RuleFor(p => p.EmergencyContactPerson).MinimumLength(4).WithMessage("Acil kişi adı 4 karakterden az olamaz.");

        RuleFor(p => p.EmergencyContactNumber).Matches(@"^\d{10}$").WithMessage("Acil kişi telefon numarası 10 haneli olmalıdır.");

        RuleFor(p => p.BloodType).NotEmpty().WithMessage("Lütfen kan grubu alanını boş bırakmayınız.");
    }
}
