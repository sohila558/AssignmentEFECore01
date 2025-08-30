using AsignmentEFECore01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentEFECore01.Configration
{
    internal class Department_Configration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(D => D.Id);

            D.Property(D => D.Name)
             .IsRequired()
             .HasColumnType("varchar")
             .HasMaxLength(50);

            D.Property(D => D.HiringDate)
             .HasDefaultValue(DateTime.Now);
        }
    }
}
