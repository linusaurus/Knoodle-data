using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Weaselware.Knoodle.Data.Models;
using System.Text;

namespace Weaselware.Knoodle.Data.EFCode
{
    public class AssemblyConfig: IEntityTypeConfiguration<Assembly>
    {

        public void Configure(EntityTypeBuilder<Assembly> entity)
        {
            entity.HasKey(p => p.AssemblyID);
            // Relationships ----------------------------
            entity.HasMany(pr => pr.SubAssemblies).WithOne().HasForeignKey(r => r.AssemblyID);
        }
    }
}
