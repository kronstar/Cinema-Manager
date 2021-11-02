using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class BillDetailsDAO
    {
        public static bool CreateBillDetails(string BillID, string SeatID, float Price)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateBillDetails @BillID , @SeatID , @Price", new object[] { BillID, SeatID, Price });
            return result > 0;
        }

        public static DataTable GetClientBillDetails(string BillID)
        {
            string query = "Select BillDetailsID AS [Mã chi tiết hoá đơn], SeatID AS [Số ghế], Price AS [Giá ghế] from BillDetails where BillID = '" + BillID + "'";
            return DataDAO.ExecuteQuery(query);
        }
    }
}
