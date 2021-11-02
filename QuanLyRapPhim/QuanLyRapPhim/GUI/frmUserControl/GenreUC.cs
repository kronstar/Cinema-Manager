using QuanLyRapPhim.DAO;
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
    public partial class GenreUC : UserControl
    {
        BindingSource genreList = new BindingSource();

        public GenreUC()
        {
            InitializeComponent();
            LoadGenre();
        }

        void LoadGenre()
        {
            dgvGenre.DataSource = genreList;
            LoadGenreList();
            AddGenreBinding();
        }
        void LoadGenreList()
        {
            genreList.DataSource = GenreDAO.GetGenre();
        }
        void AddGenreBinding()
        {
            txtGenreID.DataBindings.Add("Text", dgvGenre.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never);
            txtGenreName.DataBindings.Add("Text", dgvGenre.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never);
        }
        private void btnShowGenre_Click(object sender, EventArgs e)
        {
            LoadGenreList();
        }

        void CreateGenre(string GenreID, string GenreName)
        {
            if (GenreDAO.CreateGenre(GenreID, GenreName))
            {
                MessageBox.Show("Thêm thể loại thành công");
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại");
            }
        }

        void EditGenre(string GenreID, string GenreName)
        {
            if (GenreDAO.EditGenre(GenreID, GenreName))
            {
                MessageBox.Show("Sửa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại");
            }
        }

        void DeleteGenre(string GenreID)
        {
            if (GenreDAO.DeleteGenre(GenreID))
            {
                MessageBox.Show("Xóa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa thể loại thất bại");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            CreateGenre(GenreID, GenreName);
            LoadGenreList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            DeleteGenre(GenreID);
            LoadGenreList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            EditGenre(GenreID, GenreName);
            LoadGenreList();
        }
    }
}