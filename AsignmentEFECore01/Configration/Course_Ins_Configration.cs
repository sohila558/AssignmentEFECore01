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
    internal class Course_Ins_Configration : IEntityTypeConfiguration<Course_ins>
    {
        public void Configure(EntityTypeBuilder<Course_ins> C)
        {
            C.HasKey(C => new { C.Course_Id, C.Ins_Id });

            C.Property(C => C.Evaluate)
             .IsRequired()
             .HasColumnType("varchar");
             
        }
    }
}
