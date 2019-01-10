using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Weaselware.Knoodle.Data.Models;
using System.Text;

namespace Weaselware.Knoodle.Data.EFCode
{
    public class JObsConfig: IEntityTypeConfiguration<Job>
    {

        public void Configure(EntityTypeBuilder<Job> entity)
        {
            entity.HasKey(p => p.Job_id);
            // Relationships ----------------------------
            entity.HasMany(pr => pr.ProductionGroup).WithOne().HasForeignKey(r => r.JobID);
        }
    }
}
