namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public Account(string Username, string StaffID, int AccountType, string Pass = null)
        {
            this.Username = Username;
            this.Pass = Pass;
            this.StaffID = StaffID;
            this.AccountType = AccountType;
        }

        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Pass = row["Pass"].ToString();
            this.StaffID = row["StaffID"].ToString();
            this.AccountType = (int)row["AccountType"];
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1000)]
        public string Pass { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string StaffID { get; set; }

        public int AccountType { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
