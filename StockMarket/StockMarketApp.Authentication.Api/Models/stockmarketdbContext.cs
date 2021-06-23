using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StockMarketApp.Authentication.Api.Models
{
    public partial class stockmarketdbContext : DbContext
    {
        public stockmarketdbContext()
        {
        }

        public stockmarketdbContext(DbContextOptions<stockmarketdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Ipodetail> Ipodetails { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Stockexchange> Stockexchanges { get; set; }
        public virtual DbSet<Stockprice> Stockprices { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-P3H3QQO\\SQLEXPRESS;Database=stockmarketdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyCode);

                entity.ToTable("company");

                entity.Property(e => e.CompanyCode)
                    .ValueGeneratedNever()
                    .HasColumnName("companyCode");

                entity.Property(e => e.BoardDirector)
                    .HasMaxLength(50)
                    .HasColumnName("boardDirector");

                entity.Property(e => e.Ceo)
                    .HasMaxLength(50)
                    .HasColumnName("ceo");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("companyName");

                entity.Property(e => e.ListedStockExchange)
                    .HasMaxLength(50)
                    .HasColumnName("listedStockExchange");

                entity.Property(e => e.SectorId).HasColumnName("sectorID");

                entity.Property(e => e.Turnover).HasColumnName("turnover");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_company_sector");
            });

            modelBuilder.Entity<Ipodetail>(entity =>
            {
                entity.HasKey(e => e.IpoId)
                    .HasName("PK_IpoDetails");

                entity.ToTable("IPODetails");

                entity.Property(e => e.IpoId).ValueGeneratedNever();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.HasOne(d => d.StockExchange)
                    .WithMany(p => p.Ipodetails)
                    .HasForeignKey(d => d.StockExchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IpoDetails_stockexchange");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.ToTable("sector");

                entity.Property(e => e.SectorId)
                    .ValueGeneratedNever()
                    .HasColumnName("sectorID");

                entity.Property(e => e.Brief)
                    .HasMaxLength(50)
                    .HasColumnName("brief");

                entity.Property(e => e.SectorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sectorName");
            });

            modelBuilder.Entity<Stockexchange>(entity =>
            {
                entity.ToTable("stockexchange");

                entity.Property(e => e.StockExchangeId)
                    .ValueGeneratedNever()
                    .HasColumnName("stockExchangeID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Brief)
                    .HasMaxLength(50)
                    .HasColumnName("brief");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasColumnName("remarks");

                entity.Property(e => e.StockExchangeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("stockExchangeName");
            });

            modelBuilder.Entity<Stockprice>(entity =>
            {
                entity.ToTable("stockprice");

                entity.Property(e => e.StockpriceId).HasColumnName("stockpriceID");

                entity.Property(e => e.CompanyCode).HasColumnName("companyCode");

                entity.Property(e => e.CurrentPrice).HasColumnName("currentPrice");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.StockExchangeId).HasColumnName("stockExchangeID");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.HasOne(d => d.StockExchange)
                    .WithMany(p => p.Stockprices)
                    .HasForeignKey(d => d.StockExchangeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stockprice_stockexchange");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Confirmed)
                    .HasMaxLength(50)
                    .HasColumnName("confirmed");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("userType")
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
