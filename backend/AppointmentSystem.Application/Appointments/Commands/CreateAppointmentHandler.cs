using AppointmentSystem.Application.Common.Interfaces;
using AppointmentSystem.Application.DTOs;
using AppointmentSystem.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AppointmentSystem.Application.Appointments.Commands
{

    // Her Command kendi Handler’ına sahiptir. Bir CreateAppointmentCommand gönderildiğinde onu bu handler işler.
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, AppointmentDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateAppointmentHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AppointmentDto> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = new Appointment
            {
                Title = request.Title,
                Description = request.Description,
                Date = request.Date,
                UserId = request.UserId
            };

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<AppointmentDto>(appointment); // Entity → DTO dönüşümü
        }
    }
}
