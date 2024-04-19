using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LINQ_SP_Demo.db;

public partial class InsuranceDbSpLinqContext : DbContext
{
    public InsuranceDbSpLinqContext()
    {
    }

    public InsuranceDbSpLinqContext(DbContextOptions<InsuranceDbSpLinqContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PolicyDetail> PolicyDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=86B46DA2A2A958B;database=insuranceDB_SP_LINQ;integrated security=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PolicyDetail>(entity =>
        {
            entity.HasKey(e => e.PolicyNo).HasName("PK__policyDe__78E1E82237872AC9");

            entity.ToTable("policyDetails");

            entity.Property(e => e.PolicyNo)
                .ValueGeneratedNever()
                .HasColumnName("policyNo");
            entity.Property(e => e.PolicyName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("policyName");
            entity.Property(e => e.PolicyPremieum).HasColumnName("policyPremieum");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
