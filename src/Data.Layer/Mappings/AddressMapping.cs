﻿using Business.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Layer.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Street)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.StreetNumber)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(a => a.PostalCode)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(a => a.Complement)
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.City)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.State)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Adresses");
        }
    }
}
