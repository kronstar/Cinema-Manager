using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class GenreDAO
    {
        public static List<Genre> GetListGenre()
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataDAO.ExecuteQuery("SELECT * FROM Genre");
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static DataTable GetGenre()
        {
            return DataDAO.ExecuteQuery("SELECT GenreID AS [Mã thể loại], GenreName AS [Tên thể loại] FROM dbo.Genre");
        }

        public static bool CreateGenre(string GenreID, string GenreName)
        {
            int result = DataDAO.ExecuteNonQuery("EXEC CreateGenre @GenreID , @GenreName ", new object[] { GenreID, GenreName });
            return result > 0;
        }

        public static bool EditGenre(string GenreID, string GenreName)
        {
            string command = string.Format("UPDATE dbo.Genre SET GenreName = N'{0}' WHERE GenreID = '{2}'", GenreName, GenreID);
            int result = DataDAO.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteGenre(string GenreID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieClassification WHERE GenreID = '" + GenreID + "'");

            int result = DataDAO.ExecuteNonQuery("DELETE dbo.Genre WHERE GenreID = '" + GenreID + "'");
            return result > 0;
        }
    }
}