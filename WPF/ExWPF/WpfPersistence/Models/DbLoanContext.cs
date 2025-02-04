using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace WpfPersistence.Models;

public partial class DbLoanContext : DbContext
{
    public DbLoanContext()
    {
    }

    public DbLoanContext(DbContextOptions<DbLoanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ref<SLoan>> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=db_loan;Trusted_Connection=true;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ref<SLoan>>(entity => 
        {
            
            entity.HasKey(e => e.LoanId).HasName("PK__loan__A1F79554C739D198");

            entity.ToTable("loan");

            entity.Property(e => e.LoanId).HasColumnName("loan_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.LoanName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("loan_name");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Periodicity).HasColumnName("periodicity");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.RefundDivider).HasColumnName("refund_divider");
            entity.Property(e => e.Refunds).HasColumnName("refunds");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
