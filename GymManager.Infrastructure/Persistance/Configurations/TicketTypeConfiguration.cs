﻿using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistance.Configurations
{
    public partial class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.ToTable("TicketTypes");

            builder.Property(x => x.Price)
                .HasColumnType("decimal(6,3)");


        }
    }
}