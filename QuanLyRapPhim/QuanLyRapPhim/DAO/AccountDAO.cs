using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class AccountDAO
    {
        private AccountDAO() { }

        //Đăng nhập, thực thi lệnh trực tiếp từ sql
        public static int Login(string Username, string Pass)
        {
            string query = "Login @Username , @Pass";
            DataTable result = DataDAO.ExecuteQuery(query, new object[] { Username, Pass });

            if (result == null)
                return -1;
            else if (result.Rows.Count > 0)
                return 1;
            else
                return 0;
        }

        //Lấy thông tin tài khoản từ biến đầu vào là tên đăng nhập
        public static Account GetAccountByUsername(string Username)
        {
            DataTable data = DataDAO.ExecuteQuery("Select * from Account where Username = '" + Username + "'");

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }

            return null;
        }

        //Lấy thông tin danh sách toàn bộ tài khoản
        public static DataTable GetAccountList()
        {
            return DataDAO.ExecuteQuery("GetAccountList");
        }

        #region Thay đổi mật khẩu cho tài khoản
        //public static bool UpdatePasswordForAccount(string Username, string Pass, string NewPass)
        //{
        //    string OldPass = Pass;
        //    int result = DataDAO.ExecuteNonQuery("EXEC UpdatePasswordForAccount @Username , @Pass , @NewPass", new object[] { Username, OldPass, NewPass });
        //    return result > 0;
        //}
        #endregion

        #region Xoá tài khoản của nhân viên với biến đầu vào là mã nhân viên
        public static void DeleteAccountByStaffID(string StaffID)
        {
            DataDAO.ExecuteQuery("DELETE dbo.Account WHERE StaffID = '" + StaffID + "'");
        }
        #endregion

        #region Tạo tài khoản
        //public static bool CreateAccount(string Username, string StaffID)
        //{
        //    int result = DataDAO.ExecuteNonQuery("EXEC CreateAccount @Username , @StaffID ", new object[] { Username, StaffID });
        //    return result > 0;
        //}
        #endregion

        #region Cập nhật tài khoản
        //public static bool UpdateAccount(string Username)
        //{
        //    string command = string.Format("UpdateAccount  @username , @AccountType", new object[] { Username });
        //    int result = DataDAO.ExecuteNonQuery(command);
        //    return result > 0;
        //}
        #endregion

        #region Xoá tài khoản
        public static bool DeleteAccount(string Username)
        {
            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Account WHERE Username = N'" + Username + "'");
            return result > 0;
        }
        #endregion

        #region Tìm tài khoản
        //public static DataTable SearchAccount(string StaffName)
        //{
        //    return DataDAO.ExecuteQuery("EXEC SearchAccount @StaffName ", new object[] { StaffName });
        //}
        #endregion

        #region Đặt lại mật khẩu cho tài khoản
        //public static bool ResetPasswordForAccount(string Username)
        //{
        //    int result = DataDAO.ExecuteNonQuery("ResetPasswordForAccount @Username", new object[] { Username });
        //    return result > 0;
        //}
        #endregion
    }
}