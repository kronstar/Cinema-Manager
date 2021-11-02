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
    public partial class CinemaRoomUC : UserControl
    {
        BindingSource cinemaRoomList = new BindingSource();

        public CinemaRoomUC()
        {
            InitializeComponent();
            LoadCinemaRoom();
        }

        void LoadCinemaRoom()
        {
            dgvCinemaRoom.DataSource = cinemaRoomList;
            LoadCinemaRoomList();
            AddCinemaBinding();
        }
        void LoadCinemaRoomList()
        {
            cinemaRoomList.DataSource = CinemaRoomDAO.GetCinemaRoom();
        }
        void AddCinemaBinding()
        {
            txtCinemaRoomID.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never);
            txtCinemaRoomName.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never);
            txtSeats.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Số chỗ ngồi", true, DataSourceUpdateMode.Never);
            txtStatus.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never);
            txtRows.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Số hàng ghế", true, DataSourceUpdateMode.Never);
            txtSeatPerRow.DataBindings.Add("Text", dgvCinemaRoom.DataSource, "Ghế mỗi hàng", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cmbScreenType);
        }
        void LoadScreenTypeIntoComboBox(ComboBox cmb)
        {
            cmb.DataSource = ScreenTypeDAO.GetScreenTypeList();
            cmb.DisplayMember = "ScreenName";
            cmb.ValueMember = "ScreenTypeID";
        }
        //private void txtCinemaID_TextChanged(object sender, EventArgs e)
        ////Use this to bind data between dtgv and cbo because cbo can't be applied DataBindings normally
        //{
        //    string screenName = (string)dgvCinemaRoom.SelectedCells[0].OwningRow.Cells["Tên màn hình"].Value;
        //    DTO.ScreenType screenType = ScreenTypeDAO.GetScreenTypeByName(screenName);
        //    //This is the ScreenType that we're currently selecting in dtgv

        //    cmbScreenType.SelectedItem = screenType;

        //    int index = -1;
        //    int i = 0;
        //    foreach (ScreenType item in cmbScreenType.Items)
        //    {
        //        if (item.ScreenName == screenType.ScreenName)
        //        {
        //            index = i;
        //            break;
        //        }
        //        i++;
        //    }
        //    cmbScreenType.SelectedIndex = index;
        //}

        void CreateCinemaRoom(string CinemaRoomID, string CinemaRoomName, string ScreenTypeID, int Seats, int CinemaRoomStatus, int SeatRows, int SeatPerRow)
        {
            if (CinemaRoomDAO.CreateCinemaRoom(CinemaRoomID, CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow))
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng chiếu thất bại");
            }
        }

        void EditCinemaRoom(string CinemaRoomID, string CinemaRoomName, string ScreenTypeID, int Seats, int CinemaRoomStatus, int SeatRows, int SeatPerRow)
        {
            if (CinemaRoomDAO.EditCinemaRoom(CinemaRoomID, CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
        }

        void DeleteCinemaRoom(string CinemaRoomID)
        {
            if (CinemaRoomDAO.DeleteCinemaRoom(CinemaRoomID))
            {
                MessageBox.Show("Xóa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng chiếu thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string CinemaRoomID = txtCinemaRoomID.Text;
            string CinemaRoomName = txtCinemaRoomName.Text;
            string ScreenTypeID = cmbScreenType.SelectedValue.ToString();
            int Seats = int.Parse(txtSeats.Text);
            int CinemaRoomStatus = int.Parse(txtStatus.Text);
            int SeatRows = int.Parse(txtRows.Text);
            int SeatPerRow = int.Parse(txtSeatPerRow.Text);
            EditCinemaRoom(CinemaRoomID, CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow);
            LoadCinemaRoomList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cinemaID = txtCinemaRoomID.Text;
            DeleteCinemaRoom(cinemaID);
            LoadCinemaRoomList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CinemaRoomID = txtCinemaRoomID.Text;
            string CinemaRoomName = txtCinemaRoomName.Text;
            string ScreenTypeID = cmbScreenType.SelectedValue.ToString();
            int Seats = int.Parse(txtSeats.Text);
            int CinemaRoomStatus = int.Parse(txtStatus.Text);
            int SeatRows = int.Parse(txtRows.Text);
            int SeatPerRow = int.Parse(txtSeatPerRow.Text);
            CreateCinemaRoom(CinemaRoomID, CinemaRoomName, ScreenTypeID, Seats, CinemaRoomStatus, SeatRows, SeatPerRow);
            LoadCinemaRoomList();
        }
    }
}
