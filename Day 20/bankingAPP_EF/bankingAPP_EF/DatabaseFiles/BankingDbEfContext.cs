using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bankingAPP_EF.DatabaseFiles;

public partial class BankingDbEfContext : DbContext
{
    public BankingDbEfContext()
    {
    }

    public BankingDbEfContext(DbContextOptions<BankingDbEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountsInfo> AccountsInfos { get; set; }

    public virtual DbSet<BranchInfo> BranchInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=86B46DA2A2A958B;database=bankingDB_EF;integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountsInfo>(entity =>
        {
            entity.HasKey(e => e.AccNo).HasName("PK__accounts__A4719705472283A6");

            entity.ToTable("accountsInfo");

            entity.Property(e => e.AccNo)
                .ValueGeneratedNever()
                .HasColumnName("accNo");
            entity.Property(e => e.AccBalance).HasColumnName("accBalance");
            entity.Property(e => e.AccBranch).HasColumnName("accBranch");
            entity.Property(e => e.AccIsActive).HasColumnName("accIsActive");
            entity.Property(e => e.AccName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accName");
            entity.Property(e => e.AccType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accType");

            entity.HasOne(d => d.AccBranchNavigation).WithMany(p => p.AccountsInfos)
                .HasForeignKey(d => d.AccBranch)
                .HasConstraintName("fk_accBranch");
        });

        modelBuilder.Entity<BranchInfo>(entity =>
        {
            entity.HasKey(e => e.BranchNo).HasName("PK__branchIn__751EC4A085A37F41");

            entity.ToTable("branchInfo");

            entity.Property(e => e.BranchNo)
                .ValueGeneratedNever()
                .HasColumnName("branchNo");
            entity.Property(e => e.BranchLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("branchLocation");
            entity.Property(e => e.BranchName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("branchName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
