namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("MovieTicket")]
    public partial class MovieTicket
    {
        public MovieTicket() { }

        public MovieTicket(string TicketsID, int TicketType, string ShowtimeID, string SeatID, string ClientID, float Price, int TicketStatus)
        {
            this.TicketsID = TicketsID;
            this.TicketType = TicketType;
            this.ShowtimeID = ShowtimeID;
            this.SeatID = SeatID;
            this.ClientID = ClientID;
            this.TicketStatus = TicketStatus;
            this.Price = Price;
        }

        public MovieTicket(DataRow row)
        {
            this.TicketsID = row["TicketsID"].ToString();
            this.TicketType = (int)row["TicketType"];
            this.ShowtimeID = row["ShowtimeID"].ToString();
            this.SeatID = row["SeatID"].ToString();
            this.ClientID = row["ClientID"].ToString();
            this.TicketStatus = (int)row["TicketStatus"];
            if (row["Price"].ToString() == "")
                this.Price = 0;
            else
                this.Price = float.Parse(row["Price"].ToString());
        }

        [Key]
        public string TicketsID { get; set; }

        public int TicketType { get; set; }

        [StringLength(50)]
        public string ShowtimeID { get; set; }

        [StringLength(50)]
        public string SeatID { get; set; }

        [StringLength(50)]
        public string ClientID { get; set; }

        public int TicketStatus { get; set; }

        public float Price { get; set; }

        //public virtual Client Client { get; set; }

        //public virtual Showtime Showtime { get; set; }
    }
}
