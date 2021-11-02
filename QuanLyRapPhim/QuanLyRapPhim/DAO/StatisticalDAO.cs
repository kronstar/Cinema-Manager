using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class StatisticalDAO
    {
        public static DataTable GetRevenueByMovieAndDate(string MovieID, DateTime FromDate, DateTime ToDate)
        {
            return DataDAO.ExecuteQuery("EXEC GetRevenueByMovieAndDate @MovieID , @FromDate , @ToDate", new object[] { MovieID, FromDate, ToDate });
        }
    }
}
