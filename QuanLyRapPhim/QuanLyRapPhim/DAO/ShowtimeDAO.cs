using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class ShowtimeDAO
    {
        public static DataTable GetListShowtimeByMovieFormat(string MovieFormatID, DateTime Date)
        {
            string query = "GetListShowtimeByMovieFormat @MovieFormatID , @Date";
            return DataDAO.ExecuteQuery(query, new object[] { MovieFormatID, Date });
        }
        public static DataTable GetListShowtime(DateTime Date)
        {
            string query = "GetListShowtime @Date";
            return DataDAO.ExecuteQuery(query, new object[] { Date });
        }
        public static List<Showtime> GetAllListShowtime()
        {
            List<Showtime> showtimeList = new List<Showtime>();
            DataTable data = DataDAO.ExecuteQuery("GetAllListShowtime");
            foreach (DataRow row in data.Rows)
            {
                Showtime showtime = new Showtime(row);
                showtimeList.Add(showtime);
            }
            return showtimeList;
        }
        public static List<Showtime> GetListShowtimeNotCreateMovieTicket()
        {
            List<Showtime> showtimeList = new List<Showtime>();
            DataTable data = DataDAO.ExecuteQuery("GetListShowtimeNotCreateMovieTicket");
            foreach (DataRow row in data.Rows)
            {
                Showtime showtime = new Showtime(row);
                showtimeList.Add(showtime);
            }
            return showtimeList;
        }
        public static int EditShowtimeStatus(string ShowtimeID, int ShowtimeStatus)
        {
            string query = "UpdateShowtimeStatus @ShowtimeID , @ShowtimeStatus";
            return DataDAO.ExecuteNonQuery(query, new object[] { ShowtimeID, ShowtimeStatus });
        }

        public static DataTable GetShowtime()
        {
            return DataDAO.ExecuteQuery("EXEC GetShowtime");
        }

        public static bool CreateShowtime(string ShowtimeID, string CinemaRoomID, string MovieFormatID, DateTime ShowDate, float TicketPrice)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateShowtime @ShowtimeID , @CinemaRoomID , @MovieFormatID , @ShowDate , @TicketPrice ", new object[] { ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice });
            return result > 0;
        }

        public static bool UpdateShowtime(string ShowtimeID, string CinemaRoomID, string MovieFormatID, DateTime ShowDate, float TicketPrice)
        {
            string command = string.Format("UpdateShowtime @ShowtimeID , @CinemaRoomID , @MovieFormatID , @ShowDate , @TicketPrice ");
            int result = DataDAO.ExecuteNonQuery(command, new object[] { ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice });
            return result > 0;
        }

        public static bool DeleteShowtime(string ShowtimeID)
        {
            MovieTicketDAO.DeleteMovieTicketByShowtime(ShowtimeID);

            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Showtime WHERE ShowtimeID = '" + ShowtimeID + "'");
            return result > 0;
        }

        public static DataTable SearchShowtimeByTitle(string Title)
        {
            DataTable data = DataDAO.ExecuteQuery("EXEC SearchShowtimeByTitle @Title ", new object[] { Title });
            return data;
        }
    }
}