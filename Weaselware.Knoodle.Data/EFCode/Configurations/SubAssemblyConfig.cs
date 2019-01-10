using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Weaselware.Knoodle.Data.Models;
using System.Text;


namespace Weaselware.Knoodle.Data.EFCode
    {
        public class SubAssemblyConfig : IEntityTypeConfiguration<SubAssembly>
        {

            public void Configure(EntityTypeBuilder<SubAssembly> entity)
            {
                entity.HasKey(p => p.AssemblyID);
                // Relationships ----------------------------
                entity.HasMany(pr => pr.ComponentParts).WithOne().HasForeignKey(r => r.SubAssemblyID);
            }
        }
    }


