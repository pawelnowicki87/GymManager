
using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistance.Configurations;

class AnnouncmentConfiguration : IEntityTypeConfiguration<Announcment>
{
    public void Configure(EntityTypeBuilder<Announcment> builder)
    {
        builder.ToTable("Announcments");

        builder.Property(x => x.Description)
            .IsRequired();
    }
}
