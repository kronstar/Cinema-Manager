namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        public Client(string ClientID, string ClientName, DateTime Birthday, string ClientAddress, string PhoneNumber, int IDNumber)
        {
            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.Birthday = Birthday;
            this.ClientAddress = ClientAddress;
            this.PhoneNumber = PhoneNumber;
            this.IDNumber = IDNumber;
        }

        public Client(DataRow row)
        {
            this.ClientID = row["ClientID"].ToString();
            this.ClientName = row["ClientName"].ToString();
            this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            this.ClientAddress = row["ClientAddress"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.IDNumber = (int)row["IDNumber"];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            MovieTicket = new HashSet<MovieTicket>();
        }

        [StringLength(50)]
        public string ClientID { get; set; }

        [Required]
        [StringLength(100)]
        public string ClientName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [StringLength(100)]
        public string ClientAddress { get; set; }

        [StringLength(100)]
        public string PhoneNumber { get; set; }

        public int IDNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieTicket> MovieTicket { get; set; }
    }
}
