using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class BillDAO
    {
        public static bool CreateBill(string BillID, float Price, DateTime Date, string ClientID, string ShowtimeID)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateBill @BillID , @Price , @Date , @ClientID , @ShowtimeID", new object[] { BillID, Price, Date, ClientID, ShowtimeID });
            return result > 0;
        }

        public static DataTable GetClientBill(string ClientID)
        {
            string query = "Select BillID AS [Mã hoá đơn], Date AS [Ngày mua], ShowtimeID AS [Xuất chiếu], Price AS [Giá tổng] from Bill where ClientID = '" + ClientID + "'";
            return DataDAO.ExecuteQuery(query);
        }

        public static DataTable GetBill()
        {
            return DataDAO.ExecuteQuery("EXEC GetBill");
        }
    }
}
