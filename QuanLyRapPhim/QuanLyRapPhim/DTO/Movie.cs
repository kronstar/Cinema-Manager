namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        public Movie(string MovieID, string Title, float Runtime, DateTime PreDate, DateTime EndDate, string Nation, string Director, int YearProduce)
        {
            this.MovieID = MovieID;
            this.Title = Title;
            this.Runtime = Runtime;
            this.PreDate = PreDate;
            this.EndDate = EndDate;
            this.Nation = Nation;
            this.Director = Director;
            this.YearProduce = YearProduce;
        }

        public Movie(DataRow row)
        {
            this.MovieID = row["MovieID"].ToString();
            this.Title = row["Title"].ToString();
            this.Runtime = float.Parse(row["Runtime"].ToString());
            this.PreDate = (DateTime)row["PreDate"];
            this.EndDate = (DateTime)row["EndDate"];
            this.Nation = row["Nation"].ToString();
            this.Director = row["Director"].ToString();
            this.YearProduce = (int)row["YearProduce"];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            MovieFormat = new HashSet<MovieFormat>();
            Genre = new HashSet<Genre>();
        }

        [StringLength(50)]
        public string MovieID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public float Runtime { get; set; }

        [Column(TypeName = "date")]
        public DateTime PreDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Nation { get; set; }

        [StringLength(100)]
        public string Director { get; set; }

        public int YearProduce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieFormat> MovieFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre> Genre { get; set; }
    }
}
