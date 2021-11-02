namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("CinemaRoom")]
    public partial class CinemaRoom
    {
        public CinemaRoom(string CinemaRoomID, string CinemaRoomName, string ScreenTypeID, int SeatRows, int SeatPerRow, int Seats, string CinemaRoomStatus)
        {
            this.CinemaRoomID = CinemaRoomID;
            this.CinemaRoomName = CinemaRoomName;
            this.ScreenTypeID = ScreenTypeID;
            this.SeatRows = SeatRows;
            this.SeatPerRow = SeatPerRow;
            this.Seats = Seats;
            this.CinemaRoomStatus = CinemaRoomStatus;
        }

        public CinemaRoom(DataRow row)
        {
            this.CinemaRoomID = row["CinemaRoomID"].ToString();
            this.CinemaRoomName = row["CinemaRoomName"].ToString();
            this.ScreenTypeID = row["ScreenTypeID"].ToString();
            this.SeatRows = (int)row["SeatRows"];
            this.SeatPerRow = (int)row["SeatPerRow"];
            this.Seats = (int)row["Seats"];
            this.CinemaRoomStatus = row["CinemaRoomStatus"].ToString();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CinemaRoom()
        {
            Showtime = new HashSet<Showtime>();
        }

        [StringLength(50)]
        public string CinemaRoomID { get; set; }

        [Required]
        [StringLength(100)]
        public string CinemaRoomName { get; set; }

        [StringLength(50)]
        public string ScreenTypeID { get; set; }

        public int SeatRows { get; set; }

        public int SeatPerRow { get; set; }

        public int Seats { get; set; }

        public string CinemaRoomStatus { get; set; }

        public virtual ScreenType ScreenType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showtime> Showtime { get; set; }
    }
}
