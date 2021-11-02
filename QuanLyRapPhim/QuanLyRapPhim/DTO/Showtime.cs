namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Showtime")]
    public partial class Showtime
    {
        public Showtime(string ShowtimeID, DateTime ShowDate, string CinemaRoomName,
            string MovieFormatID, string Title, float TicketPrice, int ShowtimeStatus)
        {
            this.ShowtimeID = ShowtimeID;
            this.CinemaRoomName = CinemaRoomName;
            this.Title = Title;
            this.ShowDate = ShowDate;
            this.MovieFormatID = MovieFormatID;
            this.TicketPrice = TicketPrice;
            this.ShowtimeStatus = ShowtimeStatus;
        }

        public Showtime(DataRow row)
        {
            this.ShowtimeID = row["ShowtimeID"].ToString();
            this.CinemaRoomName = row["CinemaRoomName"].ToString();
            this.Title = row["Title"].ToString();
            this.ShowDate = (DateTime)row["ShowDate"];
            this.MovieFormatID = row["MovieFormatID"].ToString();
            if (row["TicketPrice"].ToString() == "")
                this.TicketPrice = 0;
            else
                this.TicketPrice = float.Parse(row["TicketPrice"].ToString());
            this.ShowtimeStatus = (int)row["ShowtimeStatus"];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Showtime()
        {
            MovieTicket = new HashSet<MovieTicket>();
        }

        [StringLength(50)]
        public string ShowtimeID { get; set; }

        public DateTime ShowDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CinemaRoomName { get; set; }

        [Required]
        [StringLength(50)]
        public string MovieFormatID { get; set; }

        public float TicketPrice { get; set; }

        public int ShowtimeStatus { get; set; }

        public string Title { get; set; }

        public virtual CinemaRoom CinemaRoom { get; set; }

        public virtual MovieFormat MovieFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieTicket> MovieTicket { get; set; }
    }
}
