using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI.frmUserControl
{
    public partial class ClientUC : UserControl
    {
        BindingSource customerList = new BindingSource();

        public ClientUC()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            dgvClient.DataSource = customerList;
            LoadCustomerList();
            AddCustomerBinding();
        }

        void LoadCustomerList()
        {
            customerList.DataSource = ClientDAO.GetClient();
        }

        void AddCustomerBinding()
        {
            txtClientID.DataBindings.Add("Text", dgvClient.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvClient.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtBirthday.DataBindings.Add("Text", dgvClient.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtAddress.DataBindings.Add("Text", dgvClient.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtPhoneNumber.DataBindings.Add("Text", dgvClient.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never);
            txtIDNumber.DataBindings.Add("Text", dgvClient.DataSource, "Chứng minh nhân dân", true, DataSourceUpdateMode.Never);
        }

        void CreateClient(string ClientID, string ClientName, DateTime Birthday, string ClientAddress, string PhoneNumber, int IDNumber)
        {
            Regex phoneNumPattern = new Regex(@"(09|03|07|08|05)+([0-9]{8})");
            Regex IDNumberPattern = new Regex(@"[0-9]{9}");
            if (!IDNumberPattern.IsMatch(txtIDNumber.Text))
            {
                MessageBox.Show("Số chứng minh nhân dân không hợp lệ!");
            }
            if (string.IsNullOrEmpty(txtClientID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtBirthday.Text) || string.IsNullOrEmpty(txtIDNumber.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Không được bỏ trống các thông tin!");
            }
            if (phoneNumPattern.IsMatch(txtPhoneNumber.Text))
            {
                if (ClientDAO.CreateClient(ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }

        void EditClient(string ClientID, string ClientName, DateTime Birthday, string ClientAddress, string PhoneNumber, int IDNumber)
        {
            if (ClientDAO.EditClient(ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber))
            {
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }

        void DeleteCustomer(string ClientID)
        {
            if (ClientDAO.DeleteClient(ClientID))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ClientID = txtClientID.Text;
            string ClientName = txtName.Text;
            DateTime Birthday = DateTime.Parse(txtBirthday.Text);
            string ClientAddress = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            int IDNumber = Int32.Parse(txtIDNumber.Text);
            EditClient(ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber);
            LoadCustomerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ClientID = txtClientID.Text;
            DeleteCustomer(ClientID);
            LoadCustomerList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ClientID = txtClientID.Text;
            string ClientName = txtName.Text;
            DateTime Birthday = DateTime.Parse(txtBirthday.Text);
            string ClientAddress = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            int IDNumber = Int32.Parse(txtIDNumber.Text);
            CreateClient(ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber);
            LoadCustomerList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string cusName = txtSearch.Text;
            DataTable staffSearchList = ClientDAO.SearchClientByName(cusName);
            customerList.DataSource = staffSearchList;
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            frmClientBill frmClientBill = new frmClientBill(txtClientID.Text);
            frmClientBill.ShowDialog();
        }
    }
}
