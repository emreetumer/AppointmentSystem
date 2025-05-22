using AppointmentSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSystem.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Appointment> Appointments { get; }
        DbSet<User> Users { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        //Bu, Infrastructure katmanında implement edilecek ve Handler'lar bu interface üzerinden veritabanıyla konuşacak. Dependency Inversion prensibi uygulanıyor.
    }
}
