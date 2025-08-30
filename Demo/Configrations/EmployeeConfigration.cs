using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configrations
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(nameof(Employee.EmpId));
            E.HasKey(E => E.EmpId);

            E.Property(E => E.Name)
             .IsRequired()
             .HasColumnType("varchar")
             .HasMaxLength(50)
             .HasColumnName("EmployeeName");

            E.Property(E => E.Age).IsRequired(false);

            E.Property(E => E.Salary).HasColumnType("money");

            E.Property(E => E.DateOfCreation).HasDefaultValueSql("GETDATE()");
        }
    }
}
