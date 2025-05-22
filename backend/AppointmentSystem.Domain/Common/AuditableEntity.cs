namespace AppointmentSystem.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Bu yapı sayesinde Appointment ve User gibi tüm entity’ler otomatik olarak Id, CreatedAt, UpdatedAt gibi alanlara sahip olur. DRY prensibi uygularız.
    }
}
