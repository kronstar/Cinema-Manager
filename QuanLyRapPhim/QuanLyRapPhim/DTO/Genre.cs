namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Genre")]
    public partial class Genre
    {
        public Genre(string GenreID, string GenreName)
        {
            this.GenreID = GenreID;
            this.GenreName = GenreName;
        }

        public Genre(DataRow row)
        {
            this.GenreID = row["GenreID"].ToString();
            this.GenreName = row["GenreName"].ToString();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre()
        {
            Movie = new HashSet<Movie>();
        }

        [StringLength(50)]
        public string GenreID { get; set; }

        [Required]
        [StringLength(100)]
        public string GenreName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
