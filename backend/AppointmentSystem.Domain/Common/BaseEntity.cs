namespace AppointmentSystem.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Her entity benzersiz bir Id ile başlar
    }
}
