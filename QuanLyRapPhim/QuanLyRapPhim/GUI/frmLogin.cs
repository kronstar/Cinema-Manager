using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using QuanLyRapPhim.GUI.frmUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyRapPhim.GUI
{
    //Khai báo delegate uỷ nhiệm hàm
    public delegate void AdminLogin();
    public delegate void UserLogin();

    public partial class frmLogin : KryptonForm
    {
        public event AdminLogin adminLogin;
        public event UserLogin userLogin;

        public frmLogin()
        {
            InitializeComponent();
        }
        
        //Sự kiện khi nhấn nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Khai báo các biến gán giá trị được nhập vào từ các textbox
            string Username = txtUsername.Text;
            string Pass = txtPassword.Text;

            /* Khai báo biến để lấy kết quả từ hàm login
             * Nếu result = 1 thì thông tin đăng nhập trùng khớp với dữ liệu trong database
             * Nếu result = 0 thì không có kết quả nào trả về trùng hợp với dữ liệu
             * Trường hợp còn lại là không thể lấy dữ liệu từ database*/
            int result = Login(Username, Pass);
            if (result == 1)
            {
                /* Thực thi lện đăng nhập, truy vấn đến AccountDAO.GetAccountByUser với biến được truyền vào là giá trị
                 * được nhập từ textbox, từ đó lấy tiếp thông tin loại tài khoản */
                Account loginAccount = AccountDAO.GetAccountByUsername(Username);
                MessageBox.Show("Đăng nhập thành công");

                /* Lấy thông tin loại tài khoản trong dũ liệu
                 * Nếu là tài khoản lại 1 thì được quyền quản trị
                 * ngược lại là quyền người dùng chỉ được đặt vé
                 * các phương thức này được thực hiện tại frmHomepage */
                if (loginAccount.AccountType == 1)
                {
                    adminLogin();
                }
                else
                {
                    userLogin();
                }
            }
            else if (result == 0)
            {
                picPassword.Visible = true;
                picUsername.Visible = true;
                toolTip1.SetToolTip(picUsername, "Thông tin đăng nhập không chính xác!");
                toolTip1.SetToolTip(picPassword, "Thông tin đăng nhập không chính xác!");
                txtUsername.StateCommon.Border.Color1 = Color.FromArgb(255, 112, 87);
                txtPassword.StateCommon.Border.Color1 = Color.FromArgb(255, 112, 87);
            }
            else
            {
                MessageBox.Show("Không thể kết nối với dữ liệu!");
            }
        }

        //Thực thi đăng nhập được trả về từ kết quả của AccountDAO.Login
        private int Login(string Username, string Pass)
        {
            return AccountDAO.Login(Username, Pass);
        }

        private void lblConnectDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConnectDB frmConnectDB = new frmConnectDB();
            frmConnectDB.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = null;

            picUsername.Visible = false;
            txtUsername.StateCommon.Border.Color1 = Color.FromArgb(224,224,224);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = null;
            txtPassword.UseSystemPasswordChar = true;

            picPassword.Visible = false;
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
        }
    }
}