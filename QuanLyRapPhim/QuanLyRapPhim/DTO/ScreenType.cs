namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("ScreenType")]
    public partial class ScreenType
    {
        public ScreenType(string ScreenTypeID, string ScreenName)
        {
            this.ScreenTypeID = ScreenTypeID;
            this.ScreenName = ScreenName;
        }

        public ScreenType(DataRow row)
        {
            this.ScreenTypeID = row["ScreenTypeID"].ToString();
            this.ScreenName = row["ScreenName"].ToString();
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public ScreenType()
        //{
        //    CinemaRoom = new HashSet<CinemaRoom>();
        //    MovieFormat = new HashSet<MovieFormat>();
        //}

        [StringLength(50)]
        public string ScreenTypeID { get; set; }

        [StringLength(100)]
        public string ScreenName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CinemaRoom> CinemaRoom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieFormat> MovieFormat { get; set; }
    }
}
