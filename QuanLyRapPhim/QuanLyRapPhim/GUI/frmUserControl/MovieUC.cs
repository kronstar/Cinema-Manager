using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI.frmUserControl
{
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();

        public MovieUC()
        {
            InitializeComponent();
            //dtpPreDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today.AddDays(1);
            LoadMovie();
        }

        void LoadMovie()
        {
            dgvMovie.DataSource = movieList;
            LoadMovieList();
            AddMovieBinding();
        }
        void LoadMovieList()
        {
            movieList.DataSource = MovieDAO.GetMovie();
        }
        private void btnShowMovie_Click(object sender, EventArgs e)
        {
            LoadMovieList();
        }
        void AddMovieBinding()
        {
            txtMovieID.DataBindings.Add("Text", dgvMovie.DataSource, "Mã phim", true, DataSourceUpdateMode.Never);
            txtTitle.DataBindings.Add("Text", dgvMovie.DataSource, "Tên phim", true, DataSourceUpdateMode.Never);
            txtRuntime.DataBindings.Add("Text", dgvMovie.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtpPreDate.DataBindings.Add("Value", dgvMovie.DataSource, "Ngày khởi chiếu", true, DataSourceUpdateMode.Never);
            dtpEndDate.DataBindings.Add("Value", dgvMovie.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            txtNation.DataBindings.Add("Text", dgvMovie.DataSource, "Quốc gia", true, DataSourceUpdateMode.Never);
            txtDirector.DataBindings.Add("Text", dgvMovie.DataSource, "Đạo diễn", true, DataSourceUpdateMode.Never);
            txtYearProduce.DataBindings.Add("Text", dgvMovie.DataSource, "Năm sản xuất", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(cklGenre);
        }
        void LoadGenreIntoCheckedList(CheckedListBox ckl)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            ckl.DataSource = genreList;
            ckl.DisplayMember = "GenreName";
        }

        void CreateMovie(string MovieID, string Title, float Runtime, DateTime PreDate, DateTime EndDate, string Nation, string Director, int YearProduce)
        {
            if (MovieDAO.CreateMovie(MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce))
            {
                MessageBox.Show("Thêm phim thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
        }
        void CreateMovie_Genre(string MovieID, CheckedListBox ckl)
        //Insert into table 'PhanLoaiPhim'
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in ckl.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieClassificationDAO.CreateMovie_Genre(MovieID, checkedGenreList);
        }

        void EditMovie(string MovieID, string Title, float Runtime, DateTime PreDate, DateTime EndDate, string Nation, string Director, int YearProduce)
        {
            if (MovieDAO.UpdateMovie(MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce))
            {
                MessageBox.Show("Sửa phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại");
            }
        }
        void EditMovie_Genre(string MovieID, CheckedListBox ckl)
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in ckl.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieClassificationDAO.UpdateMovie_Genre(MovieID, checkedGenreList);
        }

        void DeleteMovie(string MovieID)
        {
            if (MovieDAO.DeleteMovie(MovieID))
            {
                MessageBox.Show("Xóa phim thành công");
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieID = txtMovieID.Text;
                string Title = txtTitle.Text;
                float Runtime = float.Parse(txtRuntime.Text);
                DateTime PreDate = dtpPreDate.Value;
                DateTime EndDate = dtpEndDate.Value;
                string Nation = txtNation.Text;
                string Director = txtDirector.Text;
                int YearProduce = int.Parse(txtYearProduce.Text);

                CreateMovie(MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce);
                CreateMovie_Genre(MovieID, cklGenre);
                LoadMovieList();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            DeleteMovie(movieID);
            LoadMovieList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MovieID = txtMovieID.Text;
            string Title = txtTitle.Text;
            float Runtime = float.Parse(txtRuntime.Text);
            DateTime PreDate = dtpPreDate.Value;
            DateTime EndDate = dtpEndDate.Value;
            string Nation = txtNation.Text;
            string Director = txtDirector.Text;
            int YearProduce = int.Parse(txtYearProduce.Text);

            EditMovie(MovieID, Title, Runtime, PreDate, EndDate, Nation, Director, YearProduce);
            EditMovie_Genre(MovieID, cklGenre);
            LoadMovieList();
        }

        private void txtMovieID_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cklGenre.Items.Count; i++)
            {
                cklGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<Genre> listMovieClassification = MovieClassificationDAO.GetListGenreByMovie(txtMovieID.Text);
            for (int i = 0; i < cklGenre.Items.Count; i++)
            {
                Genre genre = (Genre)cklGenre.Items[i];
                foreach (Genre item in listMovieClassification)
                {
                    if (genre.GenreID == item.GenreID)
                    {
                        cklGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            Movie movie = MovieDAO.GetMovieByID(txtMovieID.Text);

            if (movie == null)
                return;
        }
    }
}