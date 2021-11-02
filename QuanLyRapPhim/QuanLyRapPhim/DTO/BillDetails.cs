namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    public partial class BillDetails
    {
        public BillDetails(string BillDetailsID, string BillID, string SeatID, float Price)
        {
            this.BillDetailsID = BillDetailsID;
            this.BillID = BillID;
            this.SeatID = SeatID;
            this.Price = Price;
        }

        public BillDetails(DataRow row)
        {
            this.BillDetailsID = row["BillDetailsID"].ToString();
            this.BillID = row["BillID"].ToString();
            this.SeatID = row["SeatID"].ToString();
            this.Price = float.Parse(row["Price"].ToString());
        }

        public string BillDetailsID { get; set; }

        [StringLength(50)]
        public string BillID { get; set; }

        [StringLength(50)]
        public string SeatID { get; set; }

        public float Price { get; set; }
    }
}
