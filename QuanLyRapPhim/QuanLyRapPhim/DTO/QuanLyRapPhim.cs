using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyRapPhim.DTO
{
    public partial class QuanLyRapPhim : DbContext
    {
        public QuanLyRapPhim()
            : base("name=QuanLyRapPhim")
        {
        }

        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetails> BillDetails { get; set; }
        public virtual DbSet<CinemaRoom> CinemaRoom { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieFormat> MovieFormat { get; set; }
        public virtual DbSet<MovieTicket> MovieTicket { get; set; }
        public virtual DbSet<ScreenType> ScreenType { get; set; }
        public virtual DbSet<Showtime> Showtime { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BillDetails>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetails>()
                .Property(e => e.SeatID)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.ShowtimeID)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<CinemaRoom>()
                .Property(e => e.CinemaRoomID)
                .IsUnicode(false);

            modelBuilder.Entity<CinemaRoom>()
                .Property(e => e.ScreenTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<CinemaRoom>()
                .HasMany(e => e.Showtime)
                .WithRequired(e => e.CinemaRoom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.GenreID)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Movie)
                .WithMany(e => e.Genre)
                .Map(m => m.ToTable("MovieClassification").MapLeftKey("GenreID").MapRightKey("MovieID"));

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieID)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieFormat)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieFormat>()
                .Property(e => e.MovieFormatID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieFormat>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<MovieFormat>()
                .Property(e => e.ScreenName)
                .IsUnicode(false);

            modelBuilder.Entity<MovieFormat>()
                .HasMany(e => e.Showtime)
                .WithRequired(e => e.MovieFormat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieTicket>()
                .Property(e => e.ShowtimeID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieTicket>()
                .Property(e => e.TicketsID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieTicket>()
                .Property(e => e.SeatID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieTicket>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<ScreenType>()
                .Property(e => e.ScreenTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<ScreenType>()
                .HasMany(e => e.MovieFormat)
                .WithRequired(e => e.ScreenType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.ShowtimeID)
                .IsUnicode(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.CinemaRoomName)
                .IsUnicode(false);

            modelBuilder.Entity<Showtime>()
                .Property(e => e.MovieFormatID)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Account)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieClassification>()
                .Property(e => e.MovieID)
                .IsUnicode(false);

            modelBuilder.Entity<MovieClassification>()
                .Property(e => e.GenreID)
                .IsUnicode(false);
        }
    }
}
