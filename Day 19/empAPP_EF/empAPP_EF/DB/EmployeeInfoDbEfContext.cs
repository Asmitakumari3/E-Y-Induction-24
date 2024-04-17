using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace empAPP_EF.DB;

public partial class EmployeeInfoDbEfContext : DbContext
{
    public EmployeeInfoDbEfContext()
    {
    }

    public EmployeeInfoDbEfContext(DbContextOptions<EmployeeInfoDbEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=86B46DA2A2A958B;database=EmployeeInfoDB_EF;integrated security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__employee__AFB33592380D0DD2");

            entity.ToTable("employeeInfo");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("empNo");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
