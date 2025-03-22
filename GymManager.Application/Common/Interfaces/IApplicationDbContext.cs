
using GymManager.Domain.Entities;
using File = GymManager.Domain.Entities.File;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Application.Common.Interfaces;

public interface IApplicationDbContext : IDisposable
{
    DbSet<Address> Addresses { get; set; }
    DbSet<Client> Clients { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<EmployeeEvent> EmployeeEvents { get; set; }
    DbSet<SettingsPosition> SettingsPositions { get; set; }
    DbSet<Settings> Settings { get; set; }
    DbSet<Ticket> Tickets { get; set; }
    DbSet<TicketType> TicketTypes { get; set; }
    DbSet<File> Files { get; set; }
    DbSet<Announcment> Announcments { get; set; }
    DbSet<Language> Languages { get; set; }
    DbSet<TicketTypeTranslation> TicketTypeTranslations { get; set; }
    DbSet<Invoice> Invoices { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
