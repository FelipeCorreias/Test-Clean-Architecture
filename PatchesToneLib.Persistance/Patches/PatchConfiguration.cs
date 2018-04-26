using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatchesToneLib.Domain.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Persistance.Patches
{
    class PatchConfiguration : IEntityTypeConfiguration<Patch>
    {
        public void Configure(EntityTypeBuilder<Patch> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(255);
            builder.Property(c => c.Artist).HasMaxLength(255);
            builder.Property(c => c.Genre).HasMaxLength(255);
        }
    }
}