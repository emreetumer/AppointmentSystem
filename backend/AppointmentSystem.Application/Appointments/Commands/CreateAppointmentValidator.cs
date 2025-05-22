using FluentValidation;

namespace AppointmentSystem.Application.Appointments.Commands
{
    public class CreateAppointmentValidator : AbstractValidator<CreateAppointmentCommand>
    {
        // Bu yapı ile kötü verileri daha API’ye ulaşmadan engelleyebiliriz.
        public CreateAppointmentValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Date).GreaterThan(DateTime.Now).WithMessage("Randevu tarihi geçmiş olamaz.");
        }
    }
}
