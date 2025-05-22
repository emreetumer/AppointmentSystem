namespace AppointmentSystem.Application.DTOs
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }


        //Entity’leri doğrudan dışarı açmamak için DTO kullanılır. API dış dünyaya Appointment yerine bunu döner.
    }
}
