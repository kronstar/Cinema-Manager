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
    public partial class ShowtimeUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();

        public ShowtimeUC()
        {
            InitializeComponent();
            dtpDate.MinDate = DateTime.Today.AddDays(1);
            dtpTime.MinDate = DateTime.Now;
            LoadShowtime();
        }

        void LoadShowtime()
        {
            dgvShowtime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadMovieFormatIntoComboBox();
            AddShowtimeBinding();
        }
        void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowtimeDAO.GetShowtime();
        }
        private void btnShowShowtime_Click(object sender, EventArgs e)
        {
            LoadShowtimeList();
        }

        //Binding
        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add("Text", dgvShowtime.DataSource, "Mã lịch chiếu", true, DataSourceUpdateMode.Never);
            dtpDate.DataBindings.Add("Value", dgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            dtpTime.DataBindings.Add("Value", dgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            txtPrice.DataBindings.Add("Text", dgvShowtime.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
        void LoadMovieFormatIntoComboBox()
        {
            cmbMovieFormatID.DataSource = MovieFormatDAO.GetMovieFormat();
            cmbMovieFormatID.DisplayMember = "MovieFormatID";
        }

        //Insert
        void CreateShowtime(string ShowtimeID, string CinemaRoomID, string MovieFormatID, DateTime ShowDate, float TicketPrice)
        {
            if (ShowtimeDAO.CreateShowtime(ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice))
            {
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại");
            }
        }

        //Update
        void EditShowtime(string ShowtimeID, string CinemaRoomID, string MovieFormatID, DateTime ShowDate, float TicketPrice)
        {
            if (ShowtimeDAO.UpdateShowtime(ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice))
            {
                MessageBox.Show("Sửa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa lịch chiếu thất bại");
            }
        }

        //Delete
        void DeleteShowtime(string ShowtimeID)
        {
            if (ShowtimeDAO.DeleteShowtime(ShowtimeID))
            {
                MessageBox.Show("Xóa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch chiếu thất bại");
            }
        }

        //Search
        //private void btnSearchShowtime_Click(object sender, EventArgs e)
        //{
        //    string movieName = txtSearchShowtime.Text;
        //    showtimeList.DataSource = ShowTimesDAO.SearchShowtimeByMovieName(movieName);
        //}

        //private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnSearchShowtime.PerformClick();
        //        e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
        //    }
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ShowtimeID = txtShowtimeID.Text;
            string CinemaRoomID = ((CinemaRoom)cmbCinemaRoom.SelectedItem).CinemaRoomID;
            string MovieFormatID = ((MovieFormat)cmbMovieFormatID.SelectedItem).MovieFormatID;
            DateTime ShowDate = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float TicketPrice = float.Parse(txtPrice.Text);
            EditShowtime(ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice);
            LoadShowtimeList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            DeleteShowtime(showtimeID);
            LoadShowtimeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ShowtimeID = txtShowtimeID.Text;
            string CinemaRoomID = ((CinemaRoom)cmbCinemaRoom.SelectedItem).CinemaRoomID;
            string MovieFormatID = ((MovieFormat)cmbMovieFormatID.SelectedItem).MovieFormatID;
            DateTime ShowDate = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float TicketPrice = float.Parse(txtPrice.Text);
            CreateShowtime(ShowtimeID, CinemaRoomID, MovieFormatID, ShowDate, TicketPrice);
            LoadShowtimeList();
        }

        private void cmbMovieFormatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovieFormatID.SelectedIndex != -1)
            {
                MovieFormat formatMovieSelecting = (MovieFormat)cmbMovieFormatID.SelectedItem;
                txtTitle.Text = formatMovieSelecting.Title;
                txtScreenTypeName.Text = formatMovieSelecting.ScreenName;

                cmbCinemaRoom.DataSource = null;
                ScreenType screenType = ScreenTypeDAO.GetScreenTypeByName(formatMovieSelecting.ScreenName);
                cmbCinemaRoom.DataSource = CinemaRoomDAO.GetCinemaByScreenTypeID(screenType.ScreenTypeID);
                cmbCinemaRoom.DisplayMember = "CinemaRoomName";
            }
        }

        private void txtShowtimeID_TextChanged(object sender, EventArgs e)
        {
            #region Change selected index of ComboBox FormatMovie
            string Title = (string)dgvShowtime.SelectedCells[0].OwningRow.Cells["Tên phim"].Value;
            string ScreenName = (string)dgvShowtime.SelectedCells[0].OwningRow.Cells["Màn hình"].Value;
            MovieFormat formatMovieSelecting = MovieFormatDAO.GetMovieFormatByTitle(Title, ScreenName);
            if (formatMovieSelecting == null)
                return;
            int indexFormatMovie = -1;
            for (int i = 0; i < cmbMovieFormatID.Items.Count; i++)
            {
                MovieFormat item = cmbMovieFormatID.Items[i] as MovieFormat;
                if (item.MovieFormatID == formatMovieSelecting.MovieFormatID)
                {
                    indexFormatMovie = i;
                    break;
                }
            }
            cmbMovieFormatID.SelectedIndex = indexFormatMovie;
            #endregion
            #region Change selected index of ComboBox Cinema
            string CinemaRoomID = (string)dgvShowtime.SelectedCells[0].OwningRow.Cells["Mã phòng"].Value;
            CinemaRoom cinemaSelecting = CinemaRoomDAO.GetCinemaRoomByID(CinemaRoomID);
            //This is the Cinema that we're currently selecting in dtgv

            if (cinemaSelecting == null)
                return;

            int indexCinema = -1;
            int iCinema = 0;
            foreach (CinemaRoom item in cmbCinemaRoom.Items)
            {
                if (item.CinemaRoomID == cinemaSelecting.CinemaRoomID)
                {
                    indexCinema = iCinema;
                    break;
                }
                iCinema++;
            }
            cmbCinemaRoom.SelectedIndex = indexCinema;
            #endregion
            toolTip1.SetToolTip(cmbCinemaRoom, "Danh sách phòng chiếu hỗ trợ loại màn hình trên");
        }
    }
}
