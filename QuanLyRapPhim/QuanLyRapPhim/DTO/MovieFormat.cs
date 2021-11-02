namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("MovieFormat")]
    public partial class MovieFormat
    {
        public MovieFormat(string MovieFormatID, string Title, string ScreenName)
        {
            this.MovieFormatID = MovieFormatID;
            this.Title = Title;
            this.ScreenName = ScreenName;
        }

        public MovieFormat(DataRow row)
        {
            this.MovieFormatID = row["MovieFormatID"].ToString();
            this.Title = row["Title"].ToString();
            this.ScreenName = row["ScreenName"].ToString();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieFormat()
        {
            Showtime = new HashSet<Showtime>();
        }

        [StringLength(50)]
        public string MovieFormatID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string ScreenName { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ScreenType ScreenType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Showtime> Showtime { get; set; }
    }
}
