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
    public partial class ScreenTypeUC : UserControl
    {
        BindingSource screenTypeList = new BindingSource();

        public ScreenTypeUC()
        {
            InitializeComponent();
            LoadScreenType();
        }
        void LoadScreenType()
        {
            dgvScreenType.DataSource = screenTypeList;
            LoadScreenTypeList();
            AddScreenTypeBinding();
        }
        void LoadScreenTypeList()
        {
            screenTypeList.DataSource = ScreenTypeDAO.GetScreenType();
        }
        void AddScreenTypeBinding()
        {
            txtScreenTypeID.DataBindings.Add("Text", dgvScreenType.DataSource, "Mã loại màn hình", true, DataSourceUpdateMode.Never);
            txtScreenName.DataBindings.Add("Text", dgvScreenType.DataSource, "Tên màn hình", true, DataSourceUpdateMode.Never);
        }
        private void btnShowScreenType_Click(object sender, EventArgs e)
        {
            LoadScreenTypeList();
        }

        void CreateScreenType(string ScreenTypeID, string ScreenName)
        {
            if (ScreenTypeDAO.CreateScreenType(ScreenTypeID, ScreenName))
            {
                MessageBox.Show("Thêm loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Thêm loại màn hình thất bại");
            }
        }

        void EditScreenType(string ScreenTypeID, string ScreenName)
        {
            if (ScreenTypeDAO.UpdateScreenType(ScreenTypeID, ScreenName))
            {
                MessageBox.Show("Sửa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại màn hình thất bại");
            }
        }

        void DeleteScreenType(string ScreenTypeID)
        {
            if (ScreenTypeDAO.DeleteScreenType(ScreenTypeID))
            {
                MessageBox.Show("Xóa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại màn hình thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ScreenTypeID = txtScreenTypeID.Text;
            string ScreenName = txtScreenName.Text;
            EditScreenType(ScreenTypeID, ScreenName);
            LoadScreenTypeList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ScreenTypeID = txtScreenTypeID.Text;
            DeleteScreenType(ScreenTypeID);
            LoadScreenTypeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ScreenTypeID = txtScreenTypeID.Text;
            string ScreenName = txtScreenName.Text;
            CreateScreenType(ScreenTypeID, ScreenName);
            LoadScreenTypeList();
        }
    }
}
