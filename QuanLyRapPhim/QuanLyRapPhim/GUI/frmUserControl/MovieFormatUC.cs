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
    public partial class MovieFormatUC : UserControl
    {
        BindingSource formatList = new BindingSource();

        public MovieFormatUC()
        {
            InitializeComponent();
            LoadMovieFormate();
        }

        void LoadMovieFormate()
        {
            dgvMovieFormat.DataSource = formatList;
            LoadMovieFormatList();
            LoadMovieIDIntoCombobox(cmbMovieID);
            LoadScreenIDIntoCombobox(cmbScreenTypeID);
            AddFormatBinding();
        }
        void LoadMovieIDIntoCombobox(ComboBox cmb)
        {
            cmb.DataSource = MovieDAO.GetListMovie();
            cmb.DisplayMember = "MovieID";
            cmb.ValueMember = "MovieID";
        }

        void LoadScreenIDIntoCombobox(ComboBox cmb)
        {
            cmb.DataSource = ScreenTypeDAO.GetScreenTypeList();
            cmb.DisplayMember = "ScreenTypeID";
            cmb.ValueMember = "ScreenTypeID";
        }

        void LoadMovieFormatList()
        {
            formatList.DataSource = MovieFormatDAO.GetListMovieFormat();
        }

        void AddFormatBinding()
        {
            txtMovieFormatID.DataBindings.Add("Text", dgvMovieFormat.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }

        private void btnShowFormat_Click(object sender, EventArgs e)
        {
            LoadMovieFormatList();
        }

        void CreateMovieFormat(string MovieFormatID, string MovieID, string ScreenTypeID)
        {
            if (MovieFormatDAO.CreateMovieFormat(MovieFormatID, MovieID, ScreenTypeID))
            {
                MessageBox.Show("Thêm định dạng thành công");
            }
            else
            {
                MessageBox.Show("Thêm định dạng thất bại");
            }
        }

        void EditMovieFormat(string MovieFormatID, string MovieID, string ScreenTypeID)
        {
            if (MovieFormatDAO.EditMovieFormat(MovieFormatID, MovieID, ScreenTypeID))
            {
                MessageBox.Show("Sửa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Sửa định dạng thất bại");
            }
        }

        void DeleteMovieFormat(string MovieFormatID)
        {
            if (MovieFormatDAO.DeleteMovieFormat(MovieFormatID))
            {
                MessageBox.Show("Xóa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Xóa định dạng thất bại");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MovieFormatID = txtMovieFormatID.Text;
            string MovieID = cmbMovieID.SelectedValue.ToString();
            string ScreenTypeID = cmbScreenTypeID.SelectedValue.ToString();
            CreateMovieFormat(MovieFormatID, MovieID, ScreenTypeID);
            LoadMovieFormatList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MovieFormatID = txtMovieFormatID.Text;
            DeleteMovieFormat(MovieFormatID);
            LoadMovieFormatList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MovieFormatID = txtMovieFormatID.Text;
            string MovieID = cmbMovieID.SelectedValue.ToString();
            string ScreenTypeID = cmbScreenTypeID.SelectedValue.ToString();
            EditMovieFormat(MovieFormatID, MovieID, ScreenTypeID);
            LoadMovieFormatList();
        }

        private void cmbMovieID_SelectedValueChanged(object sender, EventArgs e)
        {
            Movie movieSelected = cmbMovieID.SelectedItem as Movie;
            txtTitle.Text = movieSelected.Title;
        }

        private void cmbScreenTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            ScreenType screenTypeSelected = cmbScreenTypeID.SelectedItem as ScreenType;
            txtScreenTypeName.Text = screenTypeSelected.ScreenName;
        }

        private void txtMovieFormatID_TextChanged(object sender, EventArgs e)
        {
            string movieID = (string)dgvMovieFormat.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
            Movie movieSelecting = MovieDAO.GetMovieByID(movieID);
            //This is the Movie that we're currently selecting in dtgv

            if (movieSelecting == null)
                return;

            //cboFormat_MovieID.SelectedItem = movieSelecting;

            int indexMovie = -1;
            int iMovie = 0;
            foreach (Movie item in cmbMovieID.Items)
            {
                if (item.Title == movieSelecting.Title)
                {
                    indexMovie = iMovie;
                    break;
                }
                iMovie++;
            }
            cmbMovieID.SelectedIndex = indexMovie;


            string ScreenName = (string)dgvMovieFormat.SelectedCells[0].OwningRow.Cells["Tên màn hình"].Value;
            ScreenType screenTypeSelecting = ScreenTypeDAO.GetScreenTypeByName(ScreenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (ScreenType item in cmbScreenTypeID.Items)
            {
                if (item.ScreenName == screenTypeSelecting.ScreenName)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            cmbScreenTypeID.SelectedIndex = indexScreen;
        }
    }
}