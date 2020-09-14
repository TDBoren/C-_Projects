using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace StudentCodeFirst
{
    class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            this.Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.StudentName)
                .IsConcurrencyToken();

            // Configure a one-to-one relationship between Student & StudentAddress
            this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
                .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}
