using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class CinemaRoomDAO
    {
        //Lấy tất cả dữ liệu phòng chiếu với tên phòng chiếu được truyền vào
        public static CinemaRoom GetCinemaRoomName(string CinemaRoomName)
        {
            string query = "select * from dbo.CinemaRoom where CinemaRoomName = '" + CinemaRoomName + "'";
            DataTable data = DataDAO.ExecuteQuery(query);
            return new CinemaRoom(data.Rows[0]);
        }

        //Lấy tất cả dữ liệu từ phòng chiếu với mã phòng chiếu được truyền vào
        public static CinemaRoom GetCinemaRoomByID(string CinemaRoomID)
        {
            string query = "select * from dbo.CinemaRoom where CinemaRoomID = '" + CinemaRoomID + "'";
            DataTable data = DataDAO.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return new CinemaRoom(data.Rows[0]);
            return null;
        }

        //Lấy tất cả dữ liệu phòng chiếu với mã màn hình được truyền vào
        public static List<CinemaRoom> GetCinemaByScreenTypeID(string ScreenTypeID)
        {
            List<CinemaRoom> cinemaRoomList = new List<CinemaRoom>();
            DataTable data = DataDAO.ExecuteQuery("select * from dbo.CinemaRoom where ScreenTypeID ='" + ScreenTypeID + "'");
            foreach (DataRow item in data.Rows)
            {
                CinemaRoom cinemaRoom = new CinemaRoom(item);
                cinemaRoomList.Add(cinemaRoom);
            }
            return cinemaRoomList;
        }

        //Lấy toàn bộ thông tin phòng chiếu, lệnh được thực thi ở sql
        public static DataTable GetCinemaRoom()
        {
            return DataDAO.ExecuteQuery("EXEC GetCinemaRoom");
        }

        //Tạo phòng chiếu mới
        public static bool CreateCinemaRoom(string CinemaRoomID, string CinemaRoomName, string ScreenTypeID, int Seats, int CinemaRoomStatus, int SeatRows, int SeatPerRow)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateCinemaRoom @CinemaRoomID , @CinemaRoomName , @ScreenTypeID , @Seats , @CinemaRoomStatus , @SeatRows , @SeatPerRow", new object[] { CinemaRoomID, CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow });
            return result > 0;
        }

        //Chỉnh sửa phòng chiếu
        public static bool EditCinemaRoom(string CinemaRoomID, string CinemaRoomName, string ScreenTypeID, int Seats, int CinemaRoomStatus, int SeatRows, int SeatPerRow)
        {
            string command = string.Format("UPDATE dbo.CinemaRoom SET CinemaRoomName = N'{0}', ScreenTypeID = '{1}', Seats = {2}, CinemaRoomStatus = {3}, SeatRows = {4}, SeatPerRow = {5} WHERE CinemaRoomID = '{6}'", CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow, CinemaRoomID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        //Xoá phòng chiếu
        public static bool DeleteCinemaRoom(string CinemaRoomID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.Showtime WHERE CinemaRoomID = '" + CinemaRoomID + "'");

            int result = DataDAO.ExecuteNonQuery("DELETE dbo.CinemaRoom WHERE CinemaRoomID = '" + CinemaRoomID + "'");
            return result > 0;
        }
    }
}