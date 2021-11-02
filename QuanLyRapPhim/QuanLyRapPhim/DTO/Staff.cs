namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public Staff(string StaffID, string StaffName, DateTime Birthday, string StaffAddress, string PhoneNumber, int IDNumber)
        {
            this.StaffID = StaffID;
            this.StaffName = StaffName;
            this.Birthday = Birthday;
            this.StaffAddress = StaffAddress;
            this.PhoneNumber = PhoneNumber;
            this.IDNumber = IDNumber;
        }

        public Staff(DataRow row)
        {
            this.StaffID = row["StaffID"].ToString();
            this.StaffName = row["StaffName"].ToString();
            this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            this.StaffAddress = row["StaffAddress"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.IDNumber = Int32.Parse(row["IDNumber"].ToString());
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Account = new HashSet<Account>();
        }

        [StringLength(50)]
        public string StaffID { get; set; }

        [Required]
        [StringLength(100)]
        public string StaffName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [StringLength(100)]
        public string StaffAddress { get; set; }

        [StringLength(100)]
        public string PhoneNumber { get; set; }

        public int IDNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account { get; set; }
    }
}
