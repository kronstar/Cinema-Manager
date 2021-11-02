using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI
{
    public partial class frmClientBill : Form
    {
        BindingSource clientBill = new BindingSource();
        BindingSource clientBillDetails = new BindingSource();
        public string ClientID;
        public frmClientBill(string ClientID)
        {
            InitializeComponent();

            dgvClientBill.DataSource = clientBill;
            clientBill.DataSource = BillDAO.GetClientBill(ClientID);
        }

        private void dgvClientBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvClientBill.CurrentCell.RowIndex;
            int columnindex = dgvClientBill.CurrentCell.ColumnIndex;

            string BillID = dgvClientBill.Rows[rowindex].Cells[columnindex].Value.ToString();
            dgvClientBillDetails.DataSource = clientBillDetails;
            clientBillDetails.DataSource = BillDetailsDAO.GetClientBillDetails(BillID);
        }
    }
}
