using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class MovieClassificationDAO
    {
        public static List<Genre> GetListGenreByMovie(string MovieID)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataDAO.ExecuteQuery("EXEC GetListGenreByMovie @MovieID", new object[] { MovieID });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static void CreateMovie_Genre(string MovieID, List<Genre> genreList)
        {
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.MovieClassification (MovieID, GenreID) VALUES  ('{0}','{1}')", MovieID, item.GenreID);
                DataDAO.ExecuteNonQuery(command);
            }
        }

        public static void UpdateMovie_Genre(string MovieID, List<Genre> genreList)
        //Idea : Delete all rows that contain movieID, then re-add all genre that have been chosen from CheckedListBox to 'PhanLoaiPhim' with movieID
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieClassification WHERE MovieID = '" + MovieID + "'");
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.MovieClassification (MovieID, GenreID) VALUES  ('{0}','{1}')", MovieID, item.GenreID);
                DataDAO.ExecuteNonQuery(command);
            }
        }

        public static void DeleteMovie_GenreByMovieID(string MovieID)
        {
            DataDAO.ExecuteNonQuery("DELETE dbo.MovieClassification WHERE MovieID = '" + MovieID + "'");
        }
    }
}