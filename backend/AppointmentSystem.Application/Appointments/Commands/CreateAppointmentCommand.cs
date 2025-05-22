using AppointmentSystem.Application.DTOs;
using MediatR;

namespace AppointmentSystem.Application.Appointments.Commands
{
    public class CreateAppointmentCommand : IRequest<AppointmentDto>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public Guid UserId { get; set; } // Kim oluşturdu bilgisi
    }
}
