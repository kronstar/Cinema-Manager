using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class ScreenTypeDAO
    {
        public static List<ScreenType> GetScreenTypeList()
        {
            List<ScreenType> screenTypeList = new List<ScreenType>();
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM dbo.ScreenType");
            foreach (DataRow item in data.Rows)
            {
                ScreenType screenType = new ScreenType(item);
                screenTypeList.Add(screenType);
            }
            return screenTypeList;
        }

        public static DataTable GetScreenType()
        {
            return DataDAO.ExecuteQuery("SELECT ScreenTypeID AS [Mã loại màn hình], ScreenName as [Tên màn hình] FROM dbo.ScreenType");
        }

        public static DataTable GetScreenTypeByMovieFormat(string ScreenTypeID)
        {
            return DataDAO.ExecuteQuery("SELECT *  FROM dbo.ScreenType where ScreenTypeID = '" + ScreenTypeID + "'");
        }

        public static bool CreateScreenType(string ScreenTypeID, string ScreenName)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateScreenType @ScreenTypeID , @ScreenName", new object[] { ScreenTypeID, ScreenName });
            return result > 0;
        }

        public static bool UpdateScreenType(string ScreenTypeID, string ScreenName)
        {
            string command = string.Format("UPDATE dbo.ScreenType SET ScreenName = N'{0}' WHERE ScreenTypeID = '{1}'", ScreenName, ScreenTypeID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteScreenType(string ScreenTypeID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.CinemaRoom WHERE ScreenTypeID = '" + ScreenTypeID + "'");
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieFormat WHERE ScreenTypeID = '" + ScreenTypeID + "'");

            int result = DataDAO.ExecuteNonQuery("DELETE dbo.ScreenType WHERE ScreenTypeID = '" + ScreenTypeID + "'");
            return result > 0;
        }

        public static ScreenType GetScreenTypeByName(string ScreenName)
        {
            ScreenType screenType = null;
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM dbo.ScreenType WHERE ScreenName = N'" + ScreenName + "'");
            foreach (DataRow item in data.Rows)
            {
                screenType = new ScreenType(item);
                return screenType;
            }
            return screenType;
        }
    }
}