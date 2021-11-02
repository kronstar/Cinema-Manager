using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class StaffDAO
    {
        public static Staff GetStaffByID(string StaffID)
        {
            Staff staff = null;
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM dbo.Staff WHERE StaffID = '" + StaffID + "'");
            foreach (DataRow item in data.Rows)
            {
                staff = new Staff(item);
                return staff;
            }
            return staff;
        }

        public static List<Staff> GetStaff()
        {
            List<Staff> staffList = new List<Staff>();
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM dbo.Staff");
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffList.Add(staff);
            }
            return staffList;
        }

        public static DataTable GetStaffList()
        {
            return DataDAO.ExecuteQuery("EXEC GetStaff");
        }

        public static bool CreateStaff(string StaffID, string StaffName, DateTime Birthday, string StaffAddress, string PhoneNumber, int IDNumber)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateStaff @StaffID , @StaffName , @Birthday , @StaffAddress , @PhoneNumber , @IDNumber ", new object[] { StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber });
            return result > 0;
        }

        public static bool UpdateStaff(string StaffID, string StaffName, DateTime Birthday, string StaffAddress, string PhoneNumber, int IDNumber)
        {
            string command = string.Format("UPDATE dbo.Staff SET StaffName = N'{0}', Birthday = '{1}', StaffAddress = N'{2}', PhoneNumber = '{3}', IDNumber = {4} WHERE id = '{5}'", StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber, StaffID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteStaff(string StaffID)
        {
            AccountDAO.DeleteAccountByStaffID(StaffID);
            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Staff WHERE StaffID = '" + StaffID + "'");
            return result > 0;
        }

        public static DataTable SearchStaff(string StaffName)
        {
            //List<Staff> searchList = new List<Staff>();
            //DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.NhanVien WHERE HoTen = N'" + name + "'");
            DataTable data = DataDAO.ExecuteQuery("EXEC SearchStaff @StaffName", new object[] { StaffName });
            //foreach (DataRow item in data.Rows)
            //{
            //	Staff staff = new Staff(item);
            //	searchList.Add(staff);
            //}
            return data;
            //TODO : Giải quyết trường hợp đang được comment
        }
    }
}