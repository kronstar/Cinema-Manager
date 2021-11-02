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

namespace QuanLyRapPhim.GUI
{
    public partial class frmConnectDB : Form
    {
        public static string DataSource;
        public static string InitialCatalog;
        public static string connectionSTR;

        public frmConnectDB()
        {
            InitializeComponent();

            if (Properties.Settings.Default.DataSource != string.Empty && Properties.Settings.Default.InitialCatalog != string.Empty)
            {
                txtServerName.Text = Properties.Settings.Default.DataSource;
                txtDBName.Text = Properties.Settings.Default.InitialCatalog;
            }
        }

        private void btnCheckConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text) || string.IsNullOrEmpty(txtDBName.Text))
            {
                MessageBox.Show("Không được bỏ trống thông tin!");
            }
            else
            {
                btnCheckConnect.Enabled = false;
                connectionSTR = "Data Source=" + txtServerName.Text + ";Initial Catalog=" + txtDBName.Text + ";Integrated Security=True";

                Properties.Settings.Default.DataSource = txtServerName.Text;
                Properties.Settings.Default.InitialCatalog = txtDBName.Text;
                Properties.Settings.Default.connectionSTR = connectionSTR;
                Properties.Settings.Default.Save();

                bool result = DataDAO.TestConnectionSQL(connectionSTR);
                if (result)
                {
                    MessageBox.Show("Kết nối thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Kết nối thất bại!");
                btnCheckConnect.Enabled = true;
            }
        }
    }
}