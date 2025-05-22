using AppointmentSystem.Domain.Common;
namespace AppointmentSystem.Domain.Entities
{
    public class Appointment : AuditableEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        // Foreign Key
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
