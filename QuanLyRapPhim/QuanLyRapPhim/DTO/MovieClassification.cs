namespace QuanLyRapPhim.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("MovieClassification")]
    public partial class MovieClassification
    {
        public MovieClassification(string MovieID, string GenreID)
        {
            this.MovieID = MovieID;
            this.GenreID = GenreID;
        }

        public MovieClassification(DataRow row)
        {
            this.MovieID = row["MovieID"].ToString();
            this.GenreID = row["GenreID"].ToString();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MovieID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GenreID { get; set; }
    }
}
