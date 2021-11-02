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
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();

        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            dgvStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.GetStaffList();
        }

        //private void btnShowStaff_Click(object sender, EventArgs e)
        //{
        //    LoadStaffList();
        //}

        void AddStaffBinding()
        {
            txtStaffID.DataBindings.Add("Text", dgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtBirthday.DataBindings.Add("Text", dgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtAddress.DataBindings.Add("Text", dgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtPhoneNumber.DataBindings.Add("Text", dgvStaff.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never);
            txtIDNumber.DataBindings.Add("Text", dgvStaff.DataSource, "Chứng minh nhân dân", true, DataSourceUpdateMode.Never);
        }

        //Thêm Staff
        void CreateStaff(string StaffID, string StaffName, DateTime Birthday, string StaffAddress, string PhoneNumber, int IDNumber)
        {
            if (StaffDAO.CreateStaff(StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        //Sửa Staff
        void EditStaff(string StaffID, string StaffName, DateTime Birthday, string StaffAddress, string PhoneNumber, int IDNumber)
        {
            if (StaffDAO.UpdateStaff(StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber))
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        //Xóa Staff
        void DeleteStaff(string StaffID)
        {
            if (StaffDAO.DeleteStaff(StaffID))
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        //Tìm kiếm Staff
        //private void btnSearchStaff_Click(object sender, EventArgs e)
        //{
        //    string staffName = txtSearchStaff.Text;
        //    DataTable staffSearchList = StaffDAO.SearchStaffByName(staffName);
        //    staffList.DataSource = staffSearchList;
        //}

        //private void txtSearchStaff_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnSearchStaff.PerformClick();
        //        e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
        //    }
        //}

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string StaffID = txtStaffID.Text;
            string StaffName = txtName.Text;
            DateTime Birthday = DateTime.Parse(txtBirthday.Text);
            string StaffAddress = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            int IDNumber = Int32.Parse(txtIDNumber.Text);
            EditStaff(StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber);
            LoadStaffList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffID.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string StaffID = txtStaffID.Text;
            string StaffName = txtName.Text;
            DateTime Birthday = DateTime.Parse(txtBirthday.Text);
            string StaffAddress = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            int IDNumber = Int32.Parse(txtIDNumber.Text);
            CreateStaff(StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber);
            LoadStaffList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string staffName = txtSearch.Text;
            DataTable staffSearchList = StaffDAO.SearchStaff(staffName);
            staffList.DataSource = staffSearchList;
        }
    }
}
