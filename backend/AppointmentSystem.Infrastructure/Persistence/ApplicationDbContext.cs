using AppointmentSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using AppointmentSystem.Application.Common.Interfaces;


namespace AppointmentSystem.Infrastructure.Persistence
{
    //DbContext, tüm veritabanı işlemlerinin kapısıdır. IApplicationDbContext interface’ini burada implemente ediyoruz.Bu sayede Application katmanı veritabanına direkt bağlı değil.
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Appointment> Appointments => Set<Appointment>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
