using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class MovieFormatDAO
    {
        public static List<MovieFormat> GetListMovieFormatByMovie(string MovieID)
        {
            List<MovieFormat> movieFormatList = new List<MovieFormat>();
            string query = "select d.MovieFormatID, p.Title, m.ScreenName " +
                "from Movie p, MovieFormat d, ScreenType m " +
                "where p.MovieID = d.MovieID and d.ScreenTypeID = m.ScreenTypeID "
                + "and p.MovieID = '" + MovieID + "'";
            DataTable data = DataDAO.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                MovieFormat format = new MovieFormat(row);
                movieFormatList.Add(format);
            }
            return movieFormatList;
        }

        public static DataTable GetMovieFormatByID(string MovieID, string ScreenTypeID)
        {
            string query = "select d.MovieFormatID, p.Title, m.ScreenName " +
                "from Movie p, MovieFormat d, ScreenType m " +
                "where p.MovieID = d.MovieID and d.ScreenTypeID = m.ScreenTypeID "
                + "and p.MovieID = '" + MovieID + "' and m.ScreenTypeID = '" + ScreenTypeID + "'";
            return DataDAO.ExecuteQuery(query);
        }

        public static MovieFormat GetMovieFormatByTitle(string Title, string ScreenName)
        {
            string command = "SELECT DD.MovieFormatID, P.Title, MH.ScreenName " +
                                "FROM dbo.MovieFormat DD, dbo.Movie P, dbo.ScreenType MH " +
                                "WHERE DD.MovieID = P.MovieID AND DD.ScreenTypeID = MH.ScreenTypeID AND P.Title = N'" + Title + "' AND MH.ScreenName = N'" + ScreenName + "'";
            DataTable data = DataDAO.ExecuteQuery(command);
            return new MovieFormat(data.Rows[0]);
        }

        public static List<MovieFormat> GetMovieFormat()
        {
            List<MovieFormat> movieFormatList = new List<MovieFormat>();
            DataTable data = DataDAO.ExecuteQuery("SELECT DD.MovieFormatID, P.Title, MH.ScreenName " +
                                                        "FROM dbo.MovieFormat DD, dbo.Movie P, dbo.ScreenType MH " +
                                                        "WHERE DD.MovieID = P.MovieID AND DD.ScreenTypeID = MH.ScreenTypeID");
            foreach (DataRow item in data.Rows)
            {
                MovieFormat movieFormat = new MovieFormat(item);
                movieFormatList.Add(movieFormat);
            }
            return movieFormatList;
        }

        public static DataTable GetListMovieFormat()
        {
            return DataDAO.ExecuteQuery("EXEC GetListMovieFormat");
        }

        public static bool CreateMovieFormat(string MovieFormatID, string MovieID, string ScreenTypeID)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateMovieFormat @MovieFormatID , @MovieID , @ScreenTypeID ", new object[] { MovieFormatID, MovieID, ScreenTypeID });
            return result > 0;
        }

        public static bool EditMovieFormat(string MovieFormatID, string MovieID, string ScreenTypeID)
        {
            string command = string.Format("UPDATE dbo.MovieFormat SET MovieID = '{0}', ScreenTypeID = '{1}' WHERE id = '{2}'", MovieID, ScreenTypeID, MovieFormatID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteMovieFormat(string MovieFormatID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.Showtime WHERE MovieFormatID = '" + MovieFormatID + "'");

            int result = DataDAO.ExecuteNonQuery("DELETE dbo.MovieFormat WHERE MovieFormatID = '" + MovieFormatID + "'");
            return result > 0;
        }
    }
}