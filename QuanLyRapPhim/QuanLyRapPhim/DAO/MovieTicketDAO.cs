using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class MovieTicketDAO
    {
        public static List<MovieTicket> GetListTicketsByShowtime(string ShowtimeID)
        {
            List<MovieTicket> movieTicketList = new List<MovieTicket>();
            string query = "select * from MovieTicket where ShowtimeID = '" + ShowtimeID + "'";
            DataTable data = DataDAO.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                MovieTicket ticket = new MovieTicket(row);
                movieTicketList.Add(ticket);
            }
            return movieTicketList;
        }

        public static List<MovieTicket> GetListTicketsSoldByShowtime(string ShowtimeID)
        {
            List<MovieTicket> movieTicketList = new List<MovieTicket>();
            string query = "select * from MovieTicket where ShowtimeID = '" + ShowtimeID + "' and TicketStatus = 1";
            DataTable data = DataDAO.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                MovieTicket ticket = new MovieTicket(row);
                movieTicketList.Add(ticket);
            }
            return movieTicketList;
        }

        public static int CountToltalTicketByShowtime(string ShowtimeID)
        {
            string query = "Select count (TicketsID) from MovieTicket where ShowtimeID ='" + ShowtimeID + "'";
            return (int)DataDAO.ExecuteScalar(query);
        }
        public static int CountTheNumberOfTicketsSoldByShowtime(string ShowtimeID)
        {
            string query = "Select count (TicketsID) from MovieTicket where ShowtimeID ='" + ShowtimeID + "' and TicketStatus = 1 ";
            return (int)DataDAO.ExecuteScalar(query);
        }
        public static int BuyTicket(string TicketsID, int TicketType, float Price)
        {
            string query = "Update dbo.MovieTicket set TicketStatus = 1, TicketType = "
                + TicketType + ", Price =" + Price + " where TicketsID = '" + TicketsID + "'";
            return DataDAO.ExecuteNonQuery(query);
        }
        public static int BuyTicket(string TicketsID, int TicketType, string ClientID, float Price)
        {
            string query = "Update dbo.MovieTicket set TicketStatus = 1, TicketType = " + TicketType
                + ", ClientID =N'" + ClientID + "', Price =" + Price + " where TicketsID = '" + TicketsID + "'";
            return DataDAO.ExecuteNonQuery(query);
        }

        public static int CreateMovieTicketByShowtime(string ShowtimeID, string SeatID)
        {
            string query = "CreateMovieTicketByShowtime @ShowtimeID , @SeatID";
            return DataDAO.ExecuteNonQuery(query, new object[] { ShowtimeID, SeatID });
        }

        public static int DeleteMovieTicketByShowtime(string ShowtimeID)
        {
            string query = "DeleteMovieTicketByShowtime @ShowtimeID";
            return DataDAO.ExecuteNonQuery(query, new object[] { ShowtimeID });
        }
    }
}