using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class MovieDAO
    {
        public static List<Movie> GetListMovieByDate(DateTime Date)
        {
            List<Movie> movieList = new List<Movie>();
            DataTable data = DataDAO.ExecuteQuery("select * from Movie where @Date <= EndDate", new object[] { Date });
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                movieList.Add(movie);
            }
            return movieList;
        }

        public static List<Movie> GetListMovie()
        {
            List<Movie> movieList = new List<Movie>();
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM Movie");
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                movieList.Add(movie);
            }
            return movieList;
        }

        public static DataTable GetMovie()
        {
            return DataDAO.ExecuteQuery("EXEC GetMovie");
        }

        public static bool CreateMovie(string MovieID, string Title, float Runtime, DateTime PreDate, DateTime EndDate, string Nation, string Director, int YearProduce)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateMovie @MovieID , @Title , @Runtime , @PreDate , @EndDate , @Nation , @Director , @YearProduce ", new object[] { MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce });
            return result > 0;
        }

        public static bool UpdateMovie(string MovieID, string Title, float Runtime, DateTime PreDate, DateTime EndDate, string Nation, string Director, int YearProduce)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC UpdateMovie @MovieID , @Title , @Runtime , @PreDate , @EndDate , @Nation , @Director , @YearProduce ", new object[] { MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce });
            return result > 0;
        }

        public static bool DeleteMovie(string MovieID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieClassification WHERE MovieID = '" + MovieID + "'");
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieFormat WHERE MovieID = '" + MovieID + "'");

            MovieClassificationDAO.DeleteMovie_GenreByMovieID(MovieID);
            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Movie WHERE MovieID = '" + MovieID + "'");
            return result > 0;
        }

        public static Movie GetMovieByID(string MovieID)
        {
            Movie movie = null;
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM dbo.Movie WHERE MovieID = '" + MovieID + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }
    }
}