using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class VoetbalSQLContext : DbContext
    {
        private string configuration;

        public VoetbalSQLContext( string dbConn)
        {
            configuration = dbConn;
        }

        public VoetbalSQLContext(DbContextOptions<VoetbalSQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clubs> Clubs { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Stadions> Stadions { get; set; }
        public virtual DbSet<TicketType> TicketType { get; set; }
        public virtual DbSet<Ticketsale> Ticketsale { get; set; }
        public virtual DbSet<UserTest> UserTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(configuration);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Clubs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PriceLh).HasColumnName("PriceLH");

                entity.Property(e => e.PriceLm).HasColumnName("PriceLM");

                entity.Property(e => e.PriceUh).HasColumnName("PriceUH");

                entity.Property(e => e.PriceUm)
                    .HasColumnName("PriceUM")
                    .HasMaxLength(10);

                entity.Property(e => e.StadionId).HasColumnName("Stadion_ID");

                entity.HasOne(d => d.Stadion)
                    .WithMany(p => p.Clubs)
                    .HasForeignKey(d => d.StadionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clubs_Stadions");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwayTeamId).HasColumnName("AwayTeam_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HomeTeamId).HasColumnName("HomeTeam_ID");

                entity.HasOne(d => d.AwayTeam)
                    .WithMany(p => p.GamesAwayTeam)
                    .HasForeignKey(d => d.AwayTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_clubs");

                entity.HasOne(d => d.HomeTeam)
                    .WithMany(p => p.GamesHomeTeam)
                    .HasForeignKey(d => d.HomeTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_clubs1");
            });

            modelBuilder.Entity<Stadions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SeatsLa)
                    .HasColumnName("SeatsLA")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsLh)
                    .HasColumnName("SeatsLH")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsLme)
                    .HasColumnName("SeatsLME")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsLmw)
                    .HasColumnName("SeatsLMW")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsUa)
                    .HasColumnName("SeatsUA")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsUh)
                    .HasColumnName("SeatsUH")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsUme)
                    .HasColumnName("SeatsUME")
                    .HasMaxLength(10);

                entity.Property(e => e.SeatsUmw)
                    .HasColumnName("SeatsUMW")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TicketType1)
                    .IsRequired()
                    .HasColumnName("TicketType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ticketsale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GameId).HasColumnName("Game_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Ticketsale)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketsale_Games");

                entity.HasOne(d => d.TicketTypeNavigation)
                    .WithMany(p => p.Ticketsale)
                    .HasForeignKey(d => d.TicketType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketsale_TicketType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ticketsale)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticketsale_UserTest");
            });

            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
