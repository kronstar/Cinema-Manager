namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public Bill(string BillID, float Price, DateTime Date, string ClientID, string ShowtimeID)
        {
            this.BillID = BillID;
            this.Price = Price;
            this.Date = Date;
            this.ClientID = ClientID;
            this.ShowtimeID = ShowtimeID;
        }

        public Bill(DataRow row)
        {
            this.BillID = row["BillID"].ToString();
            this.Price = (int)row["Price"];
            this.Date = (DateTime)row["Date"];
            this.ClientID = row["ClientID"].ToString();
            this.ShowtimeID = row["ShowtimeID"].ToString();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string BillID { get; set; }

        public float Price { get; set; }

        public DateTime Date { get; set; }

        [StringLength(50)]
        public string ClientID { get; set; }
        public string ShowtimeID { get; set; }
    }
}
